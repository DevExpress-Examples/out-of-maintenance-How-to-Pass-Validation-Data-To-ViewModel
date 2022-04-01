using System;
using System.ComponentModel;

namespace DXSample {
    public class Task : IDataErrorInfo {
        public string TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        string IDataErrorInfo.Error => StartDate > EndDate ? "Either Start Date or End Date should be corrected." : null;
        string IDataErrorInfo.this[string columnName] {
            get {
                switch (columnName) {
                    case nameof(StartDate):
                        if (StartDate > EndDate)
                            return "Start Date must be less than End Date";
                        break;
                    case nameof(EndDate):
                        if (StartDate > EndDate)
                            return "End Date must be greater than Start Date";
                        break;
                    case nameof(TaskName):
                        if (string.IsNullOrEmpty(TaskName))
                            return "Enter a task name";
                        break;
                }
                return null;
            }
        }
    }
}
