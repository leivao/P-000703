USE [SEGUROS]
GO
INSERT [dbo].[CRM_CLIENTE] ([crm_cliente], [nombre_completo], [correo_electronico]) VALUES (N'7b239b41-fe7b-4124-8f28-3e0c6d8adc91', N'Cliente Primero', N'primero@cliente.com')
GO
INSERT [dbo].[CRM_CLIENTE] ([crm_cliente], [nombre_completo], [correo_electronico]) VALUES (N'83623e53-89d3-492d-a61a-69e76256b22a', N'Sicut velit', N'velit@cliente.com')
GO
INSERT [dbo].[CRM_CLIENTE] ([crm_cliente], [nombre_completo], [correo_electronico]) VALUES (N'77105b64-764c-4a61-b853-6a726b0c2533', N'Dolor Amet', N'amet@cliente.com')
GO
INSERT [dbo].[CRM_CLIENTE] ([crm_cliente], [nombre_completo], [correo_electronico]) VALUES (N'5fce8905-1a5c-4c4f-8090-d00dce4010e7', N'Lorem Ipsum', N'ipsum@cliente.com')
GO
INSERT [dbo].[POL_TIPO_CUBRIMIENTO] ([pol_tipo_cubrimiento], [nombre], [cobertura], [activo]) VALUES (N'83dcc857-528b-429b-8bc7-754f3743580a', N'Incendio', CAST(50.00 AS Decimal(5, 2)), 1)
GO
INSERT [dbo].[POL_TIPO_CUBRIMIENTO] ([pol_tipo_cubrimiento], [nombre], [cobertura], [activo]) VALUES (N'0c5fdc9b-87de-4082-9b56-8bdc515810ce', N'Terremoto', CAST(90.00 AS Decimal(5, 2)), 1)
GO
INSERT [dbo].[POL_TIPO_CUBRIMIENTO] ([pol_tipo_cubrimiento], [nombre], [cobertura], [activo]) VALUES (N'934baa83-ac0f-4a07-9c30-f0c57e43697f', N'Robo', CAST(40.00 AS Decimal(5, 2)), 1)
GO
INSERT [dbo].[POL_TIPO_CUBRIMIENTO] ([pol_tipo_cubrimiento], [nombre], [cobertura], [activo]) VALUES (N'6075e154-42f5-4e6d-9857-f9aa6b2b55ed', N'Perdida', CAST(45.00 AS Decimal(5, 2)), 1)
GO
INSERT [dbo].[POL_TIPO_RIESGO] ([pol_tipo_riesgo], [tipo_riesgo], [activo], [cobertura_maxima]) VALUES (N'a83a0a64-6ed6-45ed-930f-13409b329c0a', N'Bajo', 1, CAST(100.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[POL_TIPO_RIESGO] ([pol_tipo_riesgo], [tipo_riesgo], [activo], [cobertura_maxima]) VALUES (N'ce5d8906-4396-4d39-bd8c-3c8c5709579b', N'Medio-alto', 1, CAST(100.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[POL_TIPO_RIESGO] ([pol_tipo_riesgo], [tipo_riesgo], [activo], [cobertura_maxima]) VALUES (N'8ee65823-6b69-4e84-b0b8-869ab4f510ec', N'Alto', 1, CAST(50.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[POL_TIPO_RIESGO] ([pol_tipo_riesgo], [tipo_riesgo], [activo], [cobertura_maxima]) VALUES (N'0d882adf-669b-41da-a993-b3efb2a5e1ed', N'Medio', 1, CAST(100.00 AS Decimal(5, 2)))
GO
