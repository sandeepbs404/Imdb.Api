/****** Object:  Table [dbo].[PersonDetail]    Script Date: 13-08-2018 06:27:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PersonDetail](
	[Id] [int] NOT NULL,
	[PersonId] [int] NULL,
	[RoleId] [int] NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [varchar](100) NULL,
 CONSTRAINT [PK_PersonDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PersonDetail]  WITH CHECK ADD  CONSTRAINT [FK_PersonDetail_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO

ALTER TABLE [dbo].[PersonDetail] CHECK CONSTRAINT [FK_PersonDetail_Person]
GO

ALTER TABLE [dbo].[PersonDetail]  WITH CHECK ADD  CONSTRAINT [FK_PersonDetail_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([Id])
GO

ALTER TABLE [dbo].[PersonDetail] CHECK CONSTRAINT [FK_PersonDetail_Role]
GO


