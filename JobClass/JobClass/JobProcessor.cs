using System;
using Core;

namespace JobClass
{
    class JobProcessor
    {
        public enum JobPriorityEnum { Top, High, Nomal, Low } //열거형 사용 

        public string JobName { get; private set; }
        public string JobScript { get; private set; }
        public int JobTimeLimit { get; private set; }

        public JobPriorityEnum JobPriority //열거형을 사용해 속성 구성 
        {
            get
            {
                return this.JobPriority;
            }    
                         
            set
            {
                JobCore.Priority = (int)value;
            }
        }

        public JobProcessor(string jobname, string jobScript, JobPriorityEnum jobprioiryEnum, int jobTimeLmit = 300) // 선택적 매개 변수 사용 
        {
            this.JobName = jobname;
            this.JobScript = jobScript;
            this.JobTimeLimit = jobTimeLmit;
            this.JobPriority = jobprioiryEnum;
        }


        public void Run()
        {
            try
            {
                if (JobStart != null)
                {
                    JobStart(this, EventArgs.Empty); //이벤트 Fire 
                }

                if (JobProgress != null)
                {
                    JobProgress(this, 0);
                }
                JobCore.PreJob();

                JobCore.InitializeJob(JobScript);

                if (JobProgress != null)
                {
                    JobProgress(this, 20);
                }
                JobCore.PreJob();

                if (JobProgress != null)
                {
                    JobProgress(this, 40);
                }

                JobCore.MainJob();

                if (JobProgress != null)
                {
                    JobProgress(this, 60);
                }

                JobCore.PostJob();

                if (JobProgress != null)
                {
                    JobProgress(this, 80);
                }

                JobCore.CloseJob();

                if (JobProgress != null)
                {
                    JobProgress(this, 100);
                }

                JobCore.PreJob();

                if (JobCompleted != null)
                {
                    JobCompleted(this, EventArgs.Empty);
                }

            }

            catch { }
           
        }

        // Event 정의

        public event EventHandler JobStart;
        public event EventHandler<int> JobProgress; //generic 사용 
        public event EventHandler JobCompleted;
    }
}
