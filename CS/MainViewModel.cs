using System;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Xpf;

namespace DXSample {
    public class MainViewModel : ViewModelBase {
        public bool HasErrors {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }
        public ObservableCollection<Task> TaskList { get; }
        public MainViewModel() {
            TaskList = new ObservableCollection<Task> {
                new Task() {
                    TaskName = "Complete Project A",
                    StartDate = new DateTime(2009, 7, 17),
                    EndDate = new DateTime(2009, 7, 10)
                },
                new Task() {
                    TaskName = "Test Website",
                    StartDate = new DateTime(2009, 7, 10),
                    EndDate = new DateTime(2009, 7, 12)
                },
                new Task() {
                    TaskName = string.Empty,
                    StartDate = new DateTime(2009, 7, 4),
                    EndDate = new DateTime(2009, 7, 6)
                }
            };
        }

        [Command]
        public void ValidateRow(RowValidationArgs args) {
            args.Result = GetValidationErrorInfo((Task)args.Item);
        }
        static ValidationErrorInfo GetValidationErrorInfo(Task task) {
            if (task.StartDate > task.EndDate)
                return new ValidationErrorInfo("Start Date must be less than End Date");
            if (string.IsNullOrEmpty(task.TaskName))
                return new ValidationErrorInfo("Enter a task name");
            return null;
        }

        [Command]
        public void InvalidRow(InvalidRowExceptionArgs args) {
            args.ExceptionMode = ExceptionMode.NoAction;
        }
    }
}
