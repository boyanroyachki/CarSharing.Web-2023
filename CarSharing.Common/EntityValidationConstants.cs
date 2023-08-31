namespace CarSharing.Common
{
    //constants, that will be used to validate the entities for the database.
    public static class EntityValidationConstants
    {
        public static class Vehicle 
        {
            public const int DescriptionMaxLength = 500;
            public const int DescriptionMinLength = 10;

            //
            public const int MakeMaxLength = 50;
            public const int MakeMinLength = 5;

            //
            public const int ModelMaxLength = 50;
            public const int ModelMinLength = 5;

            //
            public const int ModelYearMaxLength = 10; //?
            public const int ModelYearMinLength = 4;

            //
            public const int PlateNumberMaxLength = 8;
            public const int PlateNumberMinLength = 4;

            //
            public const int FuelTypeMaxLength = 50;
            public const int FuelTypeMinLength = 3;

            //
            public const int NoteFromOwnerMaxLength = 500;
            public const int NoteFromOwnerMinLength = 10;
        }
    }
}
