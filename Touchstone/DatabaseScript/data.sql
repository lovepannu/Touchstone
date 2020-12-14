SET IDENTITY_INSERT [dbo].[Batch] ON
INSERT INTO [dbo].[Batch] ([batchID], [batchName], [startDate], [endDate], [courseCost], [branch_ID], [branch_objbranchID]) VALUES (4, N'Feb Batch', N'2019-02-01 07:10:00', N'2019-04-01 07:10:00', N'13700', 1, NULL)
INSERT INTO [dbo].[Batch] ([batchID], [batchName], [startDate], [endDate], [courseCost], [branch_ID], [branch_objbranchID]) VALUES (5, N'May Batch', N'2019-05-01 07:11:00', N'2019-06-30 07:12:00', N'15000', 2, NULL)
INSERT INTO [dbo].[Batch] ([batchID], [batchName], [startDate], [endDate], [courseCost], [branch_ID], [branch_objbranchID]) VALUES (6, N'July Batch', N'2019-07-02 08:00:00', N'2019-08-29 16:00:00', N'16500', 3, NULL)
INSERT INTO [dbo].[Batch] ([batchID], [batchName], [startDate], [endDate], [courseCost], [branch_ID], [branch_objbranchID]) VALUES (7, N'sep Batch', N'2019-09-05 09:00:00', N'2019-11-25 16:00:00', N'18000', 4, NULL)
INSERT INTO [dbo].[Batch] ([batchID], [batchName], [startDate], [endDate], [courseCost], [branch_ID], [branch_objbranchID]) VALUES (8, N'Jan Batch', N'2020-01-02 08:00:00', N'2020-03-28 15:30:00', N'19500', 5, NULL)
INSERT INTO [dbo].[Batch] ([batchID], [batchName], [startDate], [endDate], [courseCost], [branch_ID], [branch_objbranchID]) VALUES (9, N'April Batch', N'2020-04-05 08:30:00', N'2020-06-20 17:00:00', N'20000', 6, NULL)
SET IDENTITY_INSERT [dbo].[Batch] OFF
SET IDENTITY_INSERT [dbo].[Branch] ON
INSERT INTO [dbo].[Branch] ([branchID], [branchName], [branchAddress]) VALUES (1, N'Touchstone', N'Amritsar, Punjab')
INSERT INTO [dbo].[Branch] ([branchID], [branchName], [branchAddress]) VALUES (2, N'touchstone immigration', N'jalandhar,punjab')
INSERT INTO [dbo].[Branch] ([branchID], [branchName], [branchAddress]) VALUES (4, N'Touchstone fly', N'Gurdaspur, punjab')
INSERT INTO [dbo].[Branch] ([branchID], [branchName], [branchAddress]) VALUES (5, N'Touchstone overseas', N'Tanda, Punjab')
INSERT INTO [dbo].[Branch] ([branchID], [branchName], [branchAddress]) VALUES (6, N'Touchstone Education', N'Batala, punjab')
INSERT INTO [dbo].[Branch] ([branchID], [branchName], [branchAddress]) VALUES (7, N'Touchstone Abroad', N'Chandigarh')
SET IDENTITY_INSERT [dbo].[Branch] OFF
SET IDENTITY_INSERT [dbo].[Student] ON
INSERT INTO [dbo].[Student] ([studentID], [studentName], [studentMobile], [studentEmail], [studentAddress], [tutor_ID], [tutor_objtutorID]) VALUES (4, N'Natisha', 253666967, N'Natisha098@gmail.com', N'XYZ', 1, NULL)
INSERT INTO [dbo].[Student] ([studentID], [studentName], [studentMobile], [studentEmail], [studentAddress], [tutor_ID], [tutor_objtutorID]) VALUES (5, N'Sumandeep kaur', 25458766, N'Deepkaur23@gmail.com', N'XYZ', 1, NULL)
INSERT INTO [dbo].[Student] ([studentID], [studentName], [studentMobile], [studentEmail], [studentAddress], [tutor_ID], [tutor_objtutorID]) VALUES (6, N'Amandeep kaur', 247547876, N'kauraman655@gmail.com', N'XYZ', 2, NULL)
INSERT INTO [dbo].[Student] ([studentID], [studentName], [studentMobile], [studentEmail], [studentAddress], [tutor_ID], [tutor_objtutorID]) VALUES (7, N'Harmandeep singh', 25466779, N'hsingh247@gmail.com', N'XYZ', 2, NULL)
INSERT INTO [dbo].[Student] ([studentID], [studentName], [studentMobile], [studentEmail], [studentAddress], [tutor_ID], [tutor_objtutorID]) VALUES (8, N'Kamalpreet kaur', 23678578, N'josan257@gmail.com', N'XYZ', 3, NULL)
INSERT INTO [dbo].[Student] ([studentID], [studentName], [studentMobile], [studentEmail], [studentAddress], [tutor_ID], [tutor_objtutorID]) VALUES (9, N'Sonia Gill', 24376878, N'gillsonia012@gmail.com', N'XYZ', 3, NULL)
INSERT INTO [dbo].[Student] ([studentID], [studentName], [studentMobile], [studentEmail], [studentAddress], [tutor_ID], [tutor_objtutorID]) VALUES (10, N'Navpreet Kaur', 24876574, N'kaurpreet098@gmail.com', N'XYZ', 4, NULL)
INSERT INTO [dbo].[Student] ([studentID], [studentName], [studentMobile], [studentEmail], [studentAddress], [tutor_ID], [tutor_objtutorID]) VALUES (11, N'Jobandeep singh', 21678006, N'singhjoban22@gmail.com', N'XYZ', 4, NULL)
INSERT INTO [dbo].[Student] ([studentID], [studentName], [studentMobile], [studentEmail], [studentAddress], [tutor_ID], [tutor_objtutorID]) VALUES (12, N'jordan sandhu', 23575498, N'sandhu247@gmail.com', N'XYZ', 5, NULL)
INSERT INTO [dbo].[Student] ([studentID], [studentName], [studentMobile], [studentEmail], [studentAddress], [tutor_ID], [tutor_objtutorID]) VALUES (13, N'kulwinder singh', 237997666, N'Ksingh879@gmail.com', N'XYZ', 5, NULL)
INSERT INTO [dbo].[Student] ([studentID], [studentName], [studentMobile], [studentEmail], [studentAddress], [tutor_ID], [tutor_objtutorID]) VALUES (14, N'Jaswinder Kaur', 26789351, N'kaurjass001@gmail.com', N'XYZ', 6, NULL)
INSERT INTO [dbo].[Student] ([studentID], [studentName], [studentMobile], [studentEmail], [studentAddress], [tutor_ID], [tutor_objtutorID]) VALUES (15, N'jashandeep singh', 26578933, N'deepsingh200@gmail.com', N'XYZ', 6, NULL)
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[Tutor] ON
INSERT INTO [dbo].[Tutor] ([tutorID], [tutorName], [tutorEmail], [tutorMobile], [tutorAddress], [branch_ID], [branch_objbranchID]) VALUES (2, N'Rajni kainth', N'kainthrajni123@gmail.com', 278427749, N'XYZ', 1, NULL)
INSERT INTO [dbo].[Tutor] ([tutorID], [tutorName], [tutorEmail], [tutorMobile], [tutorAddress], [branch_ID], [branch_objbranchID]) VALUES (3, N'Sandeep kaur', N'kaurs009@gmail.com', 25685477, N'XYZ', 2, NULL)
INSERT INTO [dbo].[Tutor] ([tutorID], [tutorName], [tutorEmail], [tutorMobile], [tutorAddress], [branch_ID], [branch_objbranchID]) VALUES (4, N'Ramandeep Kaur', N'deepkaur667@gmail.com', 25464567, N'XYZ', 3, NULL)
INSERT INTO [dbo].[Tutor] ([tutorID], [tutorName], [tutorEmail], [tutorMobile], [tutorAddress], [branch_ID], [branch_objbranchID]) VALUES (5, N'Harmandeep Kaur', N'Harmankaur012@gmail.com', 2678887, N'XYZ', 4, NULL)
INSERT INTO [dbo].[Tutor] ([tutorID], [tutorName], [tutorEmail], [tutorMobile], [tutorAddress], [branch_ID], [branch_objbranchID]) VALUES (6, N'Navdeep kaur', N'kaurnav002@gmail.com', 298753788, N'XYZ', 5, NULL)
INSERT INTO [dbo].[Tutor] ([tutorID], [tutorName], [tutorEmail], [tutorMobile], [tutorAddress], [branch_ID], [branch_objbranchID]) VALUES (7, N'Jagjit Kaur', N'jagjit022@gmail.com', 2686757, N'XYZ', 6, NULL)
SET IDENTITY_INSERT [dbo].[Tutor] OFF

