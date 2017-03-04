using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeEye
{
    public class Utils
    {
        public static String content_work_start = "Start working";
        public static String content_work_end = "Stop working";
        public static String content_rest_start = "Start resting";
        public static String content_rest_end = "Stop resting";
        public static int tickUnit = 60000;
        public enum status { Wokring, Resting };
        public static string xmlDirectory = Environment.CurrentDirectory+"\\xml";
        public static string configDirectory = xmlDirectory + "\\config";
        public static string xmlRecordFile = xmlDirectory+"\\timer.xml";
        public static string timeSettingFile = configDirectory + "\\timeConfig.xml"; 
        public static string RootNode = "root";
        public static string MessageNode = "message";
        public static string InfoNode = "info";
        public static string MessageAttribute = "date";
        public static string InfoAttribute = "time";

        public const String content_start_work = "start_work";
        public const String content_end_work = "end_work";
        public const String content_remind_work = "remind_work";
        public const String content_remind_rest = "remind_rest";
        public static String[] content_time_settings = { content_start_work, content_end_work, content_remind_work, content_remind_rest };
        public static String time_start_work = "09:00:00";
        public static String time_end_work = "18:00:00";
        public static int time_remind_work = 30;
        public static int time_remind_rest = 10;
        public static String[] value_time_settings = { time_start_work, time_end_work, time_remind_work.ToString(), time_remind_rest .ToString()};
    }
}
