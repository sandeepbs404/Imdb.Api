SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MovieCrew](
	[Id] [int] NOT NULL,
	[MovieId] [int] NULL,
	[PersonDetailId] [int] NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [varchar](100) NULL,
 CONSTRAINT [PK_MovieCrew] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[MovieCrew]  WITH CHECK ADD  CONSTRAINT [FK_MovieCrew_Movie] FOREIGN KEY([MovieId])
REFERENCES [dbo].[Movie] ([Id])
GO

ALTER TABLE [dbo].[MovieCrew] CHECK CONSTRAINT [FK_MovieCrew_Movie]
GO

ALTER TABLE [dbo].[MovieCrew]  WITH CHECK ADD  CONSTRAINT [FK_MovieCrew_PersonDetail] FOREIGN KEY([PersonDetailId])
REFERENCES [dbo].[PersonDetail] ([Id])
GO

ALTER TABLE [dbo].[MovieCrew] CHECK CONSTRAINT [FK_MovieCrew_PersonDetail]
GO
