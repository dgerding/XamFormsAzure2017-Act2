using Microsoft.Azure.Mobile.Server;

namespace XamFormsWithAzure2017.MobileAppService.DataObjects
{
    public class Item : EntityData
    {
        public string Text { get; set; }
        public string Description { get; set; }
    }
}