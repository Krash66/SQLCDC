USE [SQDmeta]
GO
/****** Object:  Table [dbo].[Test1]    Script Date: 03/28/2011 01:51:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Test1](
	[EmplNumber] [uniqueidentifier] NOT NULL,
	[SerNo] [int] NOT NULL,
	[TimeStamp1] [timestamp] NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Salary] [money] NULL,
	[BonusSmall] [smallmoney] NULL,
	[BigDate] [datetime] NULL,
	[SmallDate] [smalldatetime] NULL,
	[Bit1] [bit] NULL,
	[Tinyint1] [tinyint] NULL,
	[SmallInt1] [smallint] NULL,
	[Int1] [int] NULL,
	[BigInt1] [bigint] NULL,
	[Float1] [float] NULL,
	[Real1] [real] NULL,
	[Char1] [char](10) NULL,
	[Text1] [text] NULL,
	[Nchar1] [nchar](10) NULL,
	[Nvarchar1] [nvarchar](50) NULL,
	[Bin1] [binary](4) NULL,
	[Varbin1] [varbinary](50) NULL,
 CONSTRAINT [PK_Test1] PRIMARY KEY CLUSTERED 
(
	[EmplNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF