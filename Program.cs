using EvaluationGauthierCadet;
using System.Diagnostics;

var timer = new Stopwatch();
timer.Start();

/* Sum part */
int sum = SumCalcul.SumListNumbersUsingParallelInvokeAndAggregate(3000);

/* Files part */
string file1Path = @"D:\Travail\C#\MNS\EvaluationGauthierCadet\EvaluationGauthierCadet\Eval_file1.txt";
string file2Path = @"D:\Travail\C#\MNS\EvaluationGauthierCadet\EvaluationGauthierCadet\Eval_file2.txt";

int file1Words = 0;
int file1LoremOccurence = 0;
int file2Words = 0;
int file2LoremOccurence = 0;

var file1WordsTask = new Task<int>(() => ParseFiles.CountWordsInFile(file1Path));
var file1LoremOccurrenceTask = new Task<int>(() => ParseFiles.CountWordOccurrenceInFile(file1Path, "Lorem"));
var file2WordsTask = new Task<int>(() => ParseFiles.CountWordsInFile(file2Path));
var file2LoremOccurrenceTask = new Task<int>(() => ParseFiles.CountWordOccurrenceInFile(file2Path, "Lorem"));

List<Task<int>> tasks = new List<Task<int>>() { file1WordsTask, file1LoremOccurrenceTask, file2WordsTask, file2LoremOccurrenceTask };
tasks.ForEach(task => {
    task.Start();
});
while (tasks.Count > 0) {
    Task<int> finishedTask = await Task.WhenAny(tasks);
    if (finishedTask == file1WordsTask) {
        file1Words = file1WordsTask.Result;
    } else if (finishedTask == file1LoremOccurrenceTask) {
        file1LoremOccurence = file1LoremOccurrenceTask.Result;
    } else if (finishedTask == file2WordsTask) {
        file2Words = file2WordsTask.Result;
    } else if (finishedTask == file2LoremOccurrenceTask) {
        file2LoremOccurence = file2LoremOccurrenceTask.Result;
    }
    tasks.Remove(finishedTask);
}

/* Conclusion part */
timer.Stop();
int totalSum = sum + file1Words + file2Words + file1LoremOccurence + file2LoremOccurence;
Console.WriteLine("Total sum is : {0}\t obtained in {1}", totalSum, timer.Elapsed.ToString());