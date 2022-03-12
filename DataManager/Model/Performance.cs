﻿namespace DataManager.Model
{
    public class Performance
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Gender { get; set; }
        public string CalibrationGrade { get; set; }
        public int TimeSpentToComplete { get; set; }
        public string Pin { get; set; }
        public DateTime ComplitionDate { get; set; }
    }
}
