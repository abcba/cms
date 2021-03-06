﻿using SiteServer.CMS.Model.Enumerations;

namespace SiteServer.CMS.Model
{
    public class CreateTaskSummaryItem
    {
        public CreateTaskSummaryItem(CreateTaskInfo taskInfo, string timeSpan, bool isOver, bool isSuccess, string errorMessage)
        {
            publishmentSystemId = taskInfo.PublishmentSystemId;
            channelId = taskInfo.ChannelId;
            contentId = taskInfo.ContentId;
            templateId = taskInfo.TemplateId;
            type = ECreateTypeUtils.GetText(taskInfo.CreateType);
            name = taskInfo.Name;
            this.timeSpan = timeSpan;
            this.isOver = isOver;
            this.isSuccess = isSuccess;
            this.errorMessage = errorMessage;
        }

        public CreateTaskSummaryItem(CreateTaskLogInfo logInfo, bool isOver)
        {
            publishmentSystemId = logInfo.PublishmentSystemId;
            channelId = logInfo.ChannelId;
            contentId = logInfo.ContentId;
            templateId = logInfo.TemplateId;
            type = ECreateTypeUtils.GetText(logInfo.CreateType);
            name = logInfo.TaskName;
            timeSpan = logInfo.TimeSpan;
            this.isOver = isOver;
            isSuccess = logInfo.IsSuccess;
            errorMessage = logInfo.ErrorMessage;
        }

        public int publishmentSystemId { get; set; }
        public int channelId { get; set; }
        public int contentId { get; set; }
        public int templateId { get; set; }

        public string type { get; set; }
        public string name { get; set; }
        public string timeSpan { get; set; }
        public bool isOver { get; set; }
        public bool isSuccess { get; set; }
        public string errorMessage { get; set; }
    }
}
