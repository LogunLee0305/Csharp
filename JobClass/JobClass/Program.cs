using System;

namespace JobClass
{
   
    class Program
    {
        public static int i = 0;

        static void Main(string[] args)
        {
            JobProcessor j = new JobProcessor("job", "파워쉘 실행", 10, JobProcessor.JobPriorityEnum.High);
            j.JobStart += J_JobStart;
            j.JobCompleted += J_JobCompleted;
            j.JobProgress += J_JobProgress;
            j.JobPriority = JobProcessor.JobPriorityEnum.Low;
            j.Run();   
           
        }

        private static void J_JobProgress(object sender, int e)
        {
            Console.Write("{0}% ", e);
        }

        private static void J_JobStart(object sender, EventArgs e)
        {
            Console.WriteLine("Job Start");
        }


        private static void J_JobCompleted(object sender, EventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine("Job Completed");
        }

    }
}
