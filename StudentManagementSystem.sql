USE [StudentManagementSystem]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 4/5/2020 11:09:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassID] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mark]    Script Date: 4/5/2020 11:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mark](
	[MarkID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
	[Test1] [int] NULL,
	[Test2] [int] NULL,
	[Test3] [int] NULL,
	[FinalTest] [int] NULL,
 CONSTRAINT [PK_Mark_1] PRIMARY KEY CLUSTERED 
(
	[MarkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 4/5/2020 11:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[Gender] [bit] NOT NULL,
	[DoB] [date] NULL,
	[Addess] [nvarchar](500) NULL,
	[Phone] [nvarchar](500) NULL,
	[Email] [nvarchar](500) NULL,
	[ClassID] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 4/5/2020 11:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[SubjectID] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [nvarchar](500) NULL,
	[SubjectCode] [nchar](10) NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teach]    Script Date: 4/5/2020 11:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teach](
	[TeacherID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
 CONSTRAINT [PK_Teach_1] PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC,
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 4/5/2020 11:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[TeacherID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[Gender] [bit] NULL,
	[DoB] [date] NULL,
	[Address] [nvarchar](500) NULL,
	[Phone] [varchar](20) NULL,
	[Email] [varchar](500) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher_Class]    Script Date: 4/5/2020 11:09:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher_Class](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClassID] [int] NOT NULL,
	[TeacherID] [int] NOT NULL,
 CONSTRAINT [PK_Teacher_Class_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Class] ON 

INSERT [dbo].[Class] ([ClassID], [ClassName]) VALUES (1, N'SE111')
INSERT [dbo].[Class] ([ClassID], [ClassName]) VALUES (2, N'SE116')
INSERT [dbo].[Class] ([ClassID], [ClassName]) VALUES (3, N'SE113')
INSERT [dbo].[Class] ([ClassID], [ClassName]) VALUES (4, N'SE114')
INSERT [dbo].[Class] ([ClassID], [ClassName]) VALUES (5, N'SE1316')
INSERT [dbo].[Class] ([ClassID], [ClassName]) VALUES (6, N'SE1212')
INSERT [dbo].[Class] ([ClassID], [ClassName]) VALUES (7, N'SE1235')
INSERT [dbo].[Class] ([ClassID], [ClassName]) VALUES (8, N'SE1236')
INSERT [dbo].[Class] ([ClassID], [ClassName]) VALUES (10, N'SS11')
SET IDENTITY_INSERT [dbo].[Class] OFF
SET IDENTITY_INSERT [dbo].[Mark] ON 

INSERT [dbo].[Mark] ([MarkID], [StudentID], [SubjectID], [Test1], [Test2], [Test3], [FinalTest]) VALUES (1, 1, 1, 10, 10, 9, 9)
INSERT [dbo].[Mark] ([MarkID], [StudentID], [SubjectID], [Test1], [Test2], [Test3], [FinalTest]) VALUES (2, 2, 1, 2, 6, 6, 6)
INSERT [dbo].[Mark] ([MarkID], [StudentID], [SubjectID], [Test1], [Test2], [Test3], [FinalTest]) VALUES (3, 3, 1, 6, 4, 4, 4)
INSERT [dbo].[Mark] ([MarkID], [StudentID], [SubjectID], [Test1], [Test2], [Test3], [FinalTest]) VALUES (4, 4, 1, 6, 4, 4, 4)
INSERT [dbo].[Mark] ([MarkID], [StudentID], [SubjectID], [Test1], [Test2], [Test3], [FinalTest]) VALUES (5, 3, 3, 10, 2, 1, 0)
INSERT [dbo].[Mark] ([MarkID], [StudentID], [SubjectID], [Test1], [Test2], [Test3], [FinalTest]) VALUES (6, 4, 5, 4, 8, 6, 4)
INSERT [dbo].[Mark] ([MarkID], [StudentID], [SubjectID], [Test1], [Test2], [Test3], [FinalTest]) VALUES (10, 6, 7, 7, 9, 4, 3)
INSERT [dbo].[Mark] ([MarkID], [StudentID], [SubjectID], [Test1], [Test2], [Test3], [FinalTest]) VALUES (11, 7, 6, 8, 6, 6, 8)
INSERT [dbo].[Mark] ([MarkID], [StudentID], [SubjectID], [Test1], [Test2], [Test3], [FinalTest]) VALUES (12, 4, 5, 6, 7, 3, 9)
SET IDENTITY_INSERT [dbo].[Mark] OFF
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (1, N'Taylor Swift', 0, CAST(N'1989-12-13' AS Date), N'New York', NULL, NULL, 10)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (2, N'Ariana Grande', 0, CAST(N'1996-06-26' AS Date), N'Thành phố New York, New York, Hoa Kỳ', NULL, NULL, 2)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (3, N'Ed Sheeran', 1, CAST(N'1991-02-17' AS Date), NULL, NULL, NULL, 3)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (4, N'Lionel Messi', 1, CAST(N'1987-06-24' AS Date), NULL, NULL, NULL, 4)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (6, N'Quang', 1, CAST(N'2020-04-05' AS Date), NULL, N'12345114', N'ywtryrty', 1)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (7, N'Hoang', 0, CAST(N'2020-04-05' AS Date), N'Ninh Binh', N'412355666756', N'jkhjkghkhjk', 5)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (8, N'Taylor SwiftQuang', 0, CAST(N'1989-12-13' AS Date), N'New York1', N'123', N'13123', 1)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (9, N'Taylor SwiftQuang', 0, CAST(N'1989-12-13' AS Date), N'New York1', N'123', N'13123', 3)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (10, N'Taylor SwiftQuang', 0, CAST(N'1989-12-13' AS Date), N'New York1', N'123', N'13123', 1)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (11, N'Taylor SwiftQuang', 0, CAST(N'1989-12-13' AS Date), N'New York1', N'123', N'13123', 2)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (12, N'Taylor SwiftQuang', 0, CAST(N'1989-12-13' AS Date), N'New York1', N'123', N'13123', 1)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (13, N'Taylor SwiftQuang', 0, CAST(N'1989-12-13' AS Date), N'New York1', N'123', N'13123', 1)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (14, N'Taylor SwiftQuang', 0, CAST(N'1989-12-13' AS Date), N'New York1', N'123', N'13123', 1)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (15, N'Taylor SwiftQuang', 0, CAST(N'1989-12-13' AS Date), N'New York1', N'123', N'13123', 1)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (16, N'Taylor SwiftQuang', 0, CAST(N'1989-12-13' AS Date), N'New York1', N'123', N'13123', 1)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (17, N'Taylor SwiftQuang', 0, CAST(N'1989-12-13' AS Date), N'New York1', N'123', N'13123', 1)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (18, N'Taylor SwiftQuang', 0, CAST(N'1989-12-13' AS Date), N'New York1', N'123', N'13123', 1)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (19, N'Taylor SwiftQuang', 0, CAST(N'1989-12-13' AS Date), N'New York1', N'123', N'13123', 1)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (20, N'Taylor SwiftQuang', 0, CAST(N'1989-12-13' AS Date), N'New York1', N'123', N'13123', 8)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (21, N'Taylor SwiftQuang', 0, CAST(N'1989-12-13' AS Date), N'New York1', N'123', N'13123', 1)
INSERT [dbo].[Student] ([StudentID], [Name], [Gender], [DoB], [Addess], [Phone], [Email], [ClassID]) VALUES (22, N'Taylor SwiftQuang', 0, CAST(N'1989-12-13' AS Date), N'New York1', N'123', N'13123', 1)
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([SubjectID], [SubjectName], [SubjectCode]) VALUES (1, N'Front-end Web Development', N'PRO201    ')
INSERT [dbo].[Subject] ([SubjectID], [SubjectName], [SubjectCode]) VALUES (2, N'Introduction to Databases', N'DBI202    ')
INSERT [dbo].[Subject] ([SubjectID], [SubjectName], [SubjectCode]) VALUES (3, N'Operating Systems	', N'OSG202    ')
INSERT [dbo].[Subject] ([SubjectID], [SubjectName], [SubjectCode]) VALUES (4, N'Data Structures and Algorithms', N'CSD201    ')
INSERT [dbo].[Subject] ([SubjectID], [SubjectName], [SubjectCode]) VALUES (5, N'Computer Networking', N'NWC202    ')
INSERT [dbo].[Subject] ([SubjectID], [SubjectName], [SubjectCode]) VALUES (6, N'Software Requirement', N'SWR302    ')
INSERT [dbo].[Subject] ([SubjectID], [SubjectName], [SubjectCode]) VALUES (7, N'Software Testing', N'SWT301    ')
INSERT [dbo].[Subject] ([SubjectID], [SubjectName], [SubjectCode]) VALUES (8, N'Mobile Programming', N'PRM391    ')
INSERT [dbo].[Subject] ([SubjectID], [SubjectName], [SubjectCode]) VALUES (9, N'Principles of Marxism - Leninism', N'MLN101    ')
INSERT [dbo].[Subject] ([SubjectID], [SubjectName], [SubjectCode]) VALUES (10, N'Ho Chi Minh Ideology', N'HCM201    ')
INSERT [dbo].[Subject] ([SubjectID], [SubjectName], [SubjectCode]) VALUES (11, N'Ethics in Information technology', N'ITE302    ')
SET IDENTITY_INSERT [dbo].[Subject] OFF
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (1, 1)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (1, 2)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (1, 3)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (1, 4)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (1, 5)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (1, 6)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (1, 7)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (1, 8)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (1, 9)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (1, 11)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (2, 2)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (2, 4)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (3, 3)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (4, 3)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (4, 5)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (4, 7)
INSERT [dbo].[Teach] ([TeacherID], [SubjectID]) VALUES (5, 2)
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([TeacherID], [Name], [Gender], [DoB], [Address], [Phone], [Email]) VALUES (1, N'q', 1, CAST(N'2020-04-05' AS Date), N'q', N'q', N'q')
INSERT [dbo].[Teacher] ([TeacherID], [Name], [Gender], [DoB], [Address], [Phone], [Email]) VALUES (2, N'Quang2323', 1, CAST(N'2020-04-05' AS Date), N'quang33', N'12343', N'1234241244')
INSERT [dbo].[Teacher] ([TeacherID], [Name], [Gender], [DoB], [Address], [Phone], [Email]) VALUES (3, N'Hoang Ngu', 1, CAST(N'2020-04-05' AS Date), N'Hoang ngu', N'1234', N'12342411234244')
INSERT [dbo].[Teacher] ([TeacherID], [Name], [Gender], [DoB], [Address], [Phone], [Email]) VALUES (4, N'Dat ngu', 0, CAST(N'2020-04-05' AS Date), N'451235', N'efgsdfg`', N'fasdddgdg')
INSERT [dbo].[Teacher] ([TeacherID], [Name], [Gender], [DoB], [Address], [Phone], [Email]) VALUES (5, N'Hieu', 0, CAST(N'2020-04-05' AS Date), N'dfgvbcbxb;j''', N'kl;''j;lj;ljlk', N'ouiopuou')
INSERT [dbo].[Teacher] ([TeacherID], [Name], [Gender], [DoB], [Address], [Phone], [Email]) VALUES (6, N'quynh', 1, CAST(N'2020-04-05' AS Date), N'q', N'q', N'q')
SET IDENTITY_INSERT [dbo].[Teacher] OFF
SET IDENTITY_INSERT [dbo].[Teacher_Class] ON 

INSERT [dbo].[Teacher_Class] ([ID], [ClassID], [TeacherID]) VALUES (1, 1, 1)
INSERT [dbo].[Teacher_Class] ([ID], [ClassID], [TeacherID]) VALUES (2, 1, 2)
INSERT [dbo].[Teacher_Class] ([ID], [ClassID], [TeacherID]) VALUES (3, 2, 3)
INSERT [dbo].[Teacher_Class] ([ID], [ClassID], [TeacherID]) VALUES (7, 3, 4)
INSERT [dbo].[Teacher_Class] ([ID], [ClassID], [TeacherID]) VALUES (8, 5, 5)
INSERT [dbo].[Teacher_Class] ([ID], [ClassID], [TeacherID]) VALUES (10, 4, 5)
INSERT [dbo].[Teacher_Class] ([ID], [ClassID], [TeacherID]) VALUES (11, 6, 2)
INSERT [dbo].[Teacher_Class] ([ID], [ClassID], [TeacherID]) VALUES (12, 7, 4)
INSERT [dbo].[Teacher_Class] ([ID], [ClassID], [TeacherID]) VALUES (13, 8, 2)
INSERT [dbo].[Teacher_Class] ([ID], [ClassID], [TeacherID]) VALUES (15, 10, 2)
SET IDENTITY_INSERT [dbo].[Teacher_Class] OFF
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_Gender]  DEFAULT ((1)) FOR [Gender]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_DoB]  DEFAULT (getdate()) FOR [DoB]
GO
ALTER TABLE [dbo].[Mark]  WITH CHECK ADD  CONSTRAINT [FK_Mark_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
GO
ALTER TABLE [dbo].[Mark] CHECK CONSTRAINT [FK_Mark_Student]
GO
ALTER TABLE [dbo].[Mark]  WITH CHECK ADD  CONSTRAINT [FK_Mark_Subject] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([SubjectID])
GO
ALTER TABLE [dbo].[Mark] CHECK CONSTRAINT [FK_Mark_Subject]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Class] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ClassID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Class]
GO
ALTER TABLE [dbo].[Teach]  WITH CHECK ADD  CONSTRAINT [FK_Teach_Subject] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([SubjectID])
GO
ALTER TABLE [dbo].[Teach] CHECK CONSTRAINT [FK_Teach_Subject]
GO
ALTER TABLE [dbo].[Teach]  WITH CHECK ADD  CONSTRAINT [FK_Teach_Teacher] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teacher] ([TeacherID])
GO
ALTER TABLE [dbo].[Teach] CHECK CONSTRAINT [FK_Teach_Teacher]
GO
ALTER TABLE [dbo].[Teacher_Class]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Class_Class] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ClassID])
GO
ALTER TABLE [dbo].[Teacher_Class] CHECK CONSTRAINT [FK_Teacher_Class_Class]
GO
ALTER TABLE [dbo].[Teacher_Class]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Class_Teacher] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teacher] ([TeacherID])
GO
ALTER TABLE [dbo].[Teacher_Class] CHECK CONSTRAINT [FK_Teacher_Class_Teacher]
GO
