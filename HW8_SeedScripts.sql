USE [DBHomework8]
GO

SET IDENTITY_INSERT [dbo].[Assignments] ON 

GO
INSERT [dbo].[Assignments] ([AssignmentId], [Course], [AssignmentPriority], [AssignmentTitle], [AssignmentNotes], [AssignmentTags], [IsCompleted], [DueDate]) VALUES (1, 2, 3, N'Homework8', N'2nd and 3rd part', N'hard, coding', 1, CAST(N'2020-11-30 15:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Assignments] ([AssignmentId], [Course], [AssignmentPriority], [AssignmentTitle], [AssignmentNotes], [AssignmentTags], [IsCompleted], [DueDate]) VALUES (2, 3, 2, N'Homework4', N'Final output', N'easy, video', 0, CAST(N'2020-12-01 15:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Assignments] ([AssignmentId], [Course], [AssignmentPriority], [AssignmentTitle], [AssignmentNotes], [AssignmentTags], [IsCompleted], [DueDate]) VALUES (3, 1, 1, N'Homework7', N'add a new module', N'reading, hard, coding', 0, CAST(N'2020-12-11 17:41:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Assignments] ([AssignmentId], [Course], [AssignmentPriority], [AssignmentTitle], [AssignmentNotes], [AssignmentTags], [IsCompleted], [DueDate]) VALUES (4, 1, 2, N'Homework4', N'Some error resolution', N'video, coding', 1, CAST(N'2020-12-09 17:43:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Assignments] ([AssignmentId], [Course], [AssignmentPriority], [AssignmentTitle], [AssignmentNotes], [AssignmentTags], [IsCompleted], [DueDate]) VALUES (5, 1, 2, N'Homework4', N'modifications in display', N'easy, coding, video', 0, CAST(N'2020-12-10 17:46:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Assignments] ([AssignmentId], [Course], [AssignmentPriority], [AssignmentTitle], [AssignmentNotes], [AssignmentTags], [IsCompleted], [DueDate]) VALUES (6, 2, 3, N'Homework8', N'add a new module', N'reading, hard, coding', 1, CAST(N'2020-11-30 17:51:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Assignments] ([AssignmentId], [Course], [AssignmentPriority], [AssignmentTitle], [AssignmentNotes], [AssignmentTags], [IsCompleted], [DueDate]) VALUES (7, 4, 3, N'Homework1', N'Some error resolution', N'hard, coding', 0, CAST(N'2020-12-01 17:52:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Assignments] ([AssignmentId], [Course], [AssignmentPriority], [AssignmentTitle], [AssignmentNotes], [AssignmentTags], [IsCompleted], [DueDate]) VALUES (8, 4, 4, N'Homework1', N'modifications in display', N'easy, video', 0, CAST(N'2020-12-09 05:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Assignments] ([AssignmentId], [Course], [AssignmentPriority], [AssignmentTitle], [AssignmentNotes], [AssignmentTags], [IsCompleted], [DueDate]) VALUES (9, 3, 3, N'Homework4', N'2nd and 3rd part', N'hard', 1, CAST(N'2020-12-23 17:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Assignments] ([AssignmentId], [Course], [AssignmentPriority], [AssignmentTitle], [AssignmentNotes], [AssignmentTags], [IsCompleted], [DueDate]) VALUES (10, 3, 2, N'Homework2', N'create final View ', N'coding', 0, CAST(N'2020-12-02 18:30:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Assignments] ([AssignmentId], [Course], [AssignmentPriority], [AssignmentTitle], [AssignmentNotes], [AssignmentTags], [IsCompleted], [DueDate]) VALUES (11, 4, 2, N'Task12', N'end notes need to be practiced', N'easy, video, final', 1, CAST(N'2020-12-10 09:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Assignments] ([AssignmentId], [Course], [AssignmentPriority], [AssignmentTitle], [AssignmentNotes], [AssignmentTags], [IsCompleted], [DueDate]) VALUES (12, 1, 1, N'Homework1', N'Some error resolution', N'easy, coding, video', 0, CAST(N'2020-12-10 21:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Assignments] OFF
GO
SET IDENTITY_INSERT [dbo].[Tags] ON 

GO
INSERT [dbo].[Tags] ([TagId], [TagName]) VALUES (1, N'reading')
GO
INSERT [dbo].[Tags] ([TagId], [TagName]) VALUES (2, N'hard')
GO
INSERT [dbo].[Tags] ([TagId], [TagName]) VALUES (3, N'easy')
GO
INSERT [dbo].[Tags] ([TagId], [TagName]) VALUES (4, N'coding')
GO
INSERT [dbo].[Tags] ([TagId], [TagName]) VALUES (5, N'video')
GO
INSERT [dbo].[Tags] ([TagId], [TagName]) VALUES (9, N'medium')
GO
SET IDENTITY_INSERT [dbo].[Tags] OFF
GO
