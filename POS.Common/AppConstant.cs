namespace POS.Common
{
    public class AppConstant
    {
        // This is For Using in controllers
        public struct Areas
        {
            public const string Guide = nameof(Guide);

        }
        // This is For Using in Classes Which is Transfer to Tables in DataBase
        public struct Schemas
        {
            public const string Guide = nameof(Guide);

        }
        public struct Messages
        {
            public const string InvalidSave = "خطأ في الحفظ";
            public const string SuccessSave = " تم الحفظ";
            public const string NameRequired = "الاسم مطلوب";
            public const string NameAlreadyExists = "الاسم مستخدم من قبل";
            public const string PhoneRequired = "رقم الهاتف مطلوب";

        }
    }
}
