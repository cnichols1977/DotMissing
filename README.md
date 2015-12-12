# DotMissing
Collection of Extensions to the .NET Framework written in C#.

## DateTime Extensions 
Method|Description
------|-----------
EndOfDay|Return DateTime with time portion changed to max time.
StartOfDay|Return DateTime with time portion changed to min time.
FirstDayOfMonthDate|Return DateTime with it set to the first day of the month and the time set to min time.
LastDayOfMonthDate|Return the DateTime with it set to the last day of the month and the time set to min time.
LastDayOfMonth|Returns the int value of the last day of this DateTime's month.
IsLastDayOfMonth|Return True if the DateTime has it's day set to the last day of it's month, otherwise returns False.
FirstDayOfYearDate|Return DateTime with it set to January 1st and the time set to min time.
LastDayOfYearDate|Return the DateTime with it set to the last day of the year and the time set to min time.
IsWeekday|Return True if the DateTime is NOT a Saturday or Sunday.
IsWeekend|Return True if the DataTime is a Saturday or Sunday.

## String Extensions 
Method|Description
------|-----------
Repeat(int count)|Return the string *count* times.
ToChunks(int chunkSize)|Split the string into a Collection of strings with each string no bigger than the specified chunkSize.
ToNullOrWhiteSpace|Return True if string is null or only contains whitespace characters.
