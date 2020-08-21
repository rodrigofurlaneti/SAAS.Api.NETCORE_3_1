SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABELA_MEDICO_ESPECIALIDADE](
	[ID_MEDICO_ESPECIALIDADE] [int] IDENTITY(1,1) NOT NULL,
	[ID_MEDICO] [int] NOT NULL,
	[ID_ESPECIALIDADE] [int] NOT NULL,
 CONSTRAINT [PK_TABELA_MEDICO_ESPECIALIDADE] PRIMARY KEY CLUSTERED 
(
	[ID_MEDICO_ESPECIALIDADE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO