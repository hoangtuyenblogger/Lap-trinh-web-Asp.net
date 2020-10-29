
CREATE TABLE [dbo].[NGUOIDUNG](
	[Username] [nchar](50) NOT NULL,
	[Password] [nchar](50) NULL,
	[Hoten] [nvarchar](50) NULL,
	[SDT] [varchar](15) NULL,
	[Email] [varchar](50) NULL,
	[Quyen] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


