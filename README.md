
 הסבר על מחלקות בפרויקט IDFOperationFirstStrike

===============================
                                                                                                                                                                     מחלקה:    Aman 
===============================
תפקיד:
לייצג את אגף המודיעין (אמ"ן), האחראי לאיסוף וניתוח דיווחים על טרוריסטים.

מימוש:
- intelMessages: רשימת כל הדיווחים שנאספו (ReportMessage).
- GenerateIntel(): מייצרת 15 דיווחים אקראיים על טרוריסטים ומיקומם.
- AddReport(): מוסיפה דיווח חדש לרשימה.
- PrintMostReportedTerrorist(): מחזירה את שם הטרוריסט עם הכי הרבה דיווחים.
- getLatestReport(): מחזירה את הדיווח האחרון על טרוריסט לפי שם.

===============================
                                                                                                                                                                  מחלקה:  Terrorist 
===============================
תפקיד:
לייצג טרוריסט עם פרטים מזהים.

מימוש:
- name: שם הטרוריסט.
- getName(): מחזירה את שם הטרוריסט.

===============================
                                                                                                                                                                 מחלקה: ReportMessage
===============================
תפקיד:
לייצג דיווח על טרוריסט כולל שם, מיקום וזמן.

מימוש:
- TerroristName: שם המדווח.
- Location: מיקום.
- TimeStamp: מועד הדיווח.

===============================
                                                                                                                                                                    קובץ: Program.cs
===============================
תפקיד:
נקודת ההתחלה של התוכנית - מפעילה את כל הרכיבים.

מימוש:
- יצירת רשימת טרוריסטים.
- יצירת אובייקט Aman.
- יצירת דיווחים, הדפסת טרוריסט מוביל, הדפסת דיווח אחרון.
