SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABELA_MEDICO](
	[ID_MEDICO] [int] IDENTITY(1,1) NOT NULL,
	[NOM_MEDICO] [varchar](255) NOT NULL,
	[DOC_CPF] [varchar](14) NOT NULL,
	[DOC_CRM] [varchar](10) NOT NULL,
 CONSTRAINT [PK_TABELA_MEDICO] PRIMARY KEY CLUSTERED 
(
	[ID_MEDICO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
