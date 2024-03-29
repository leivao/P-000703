USE [SEGUROS]
GO
/****** Object:  Table [dbo].[CRM_CLIENTE]    Script Date: 23/8/2019 1:01:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CRM_CLIENTE](
	[crm_cliente] [uniqueidentifier] NOT NULL,
	[nombre_completo] [varchar](100) NOT NULL,
	[correo_electronico] [varchar](100) NOT NULL,
 CONSTRAINT [PK_CRM_CLIENTE] PRIMARY KEY CLUSTERED 
(
	[crm_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[POL_POLIZA]    Script Date: 23/8/2019 1:01:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POL_POLIZA](
	[pol_poliza] [uniqueidentifier] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[pol_tipo_cubrimiento] [uniqueidentifier] NOT NULL,
	[descripcion] [varchar](250) NOT NULL,
	[inicio_vigencia] [datetime] NOT NULL,
	[periodo_cobertura] [int] NOT NULL,
	[precio] [decimal](18, 5) NOT NULL,
	[pol_tipo_riesgo] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_POL_POLIZA] PRIMARY KEY CLUSTERED 
(
	[pol_poliza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[POL_POLIZA_X_CLIENTE]    Script Date: 23/8/2019 1:01:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POL_POLIZA_X_CLIENTE](
	[pol_poliza] [uniqueidentifier] NOT NULL,
	[crm_cliente] [uniqueidentifier] NOT NULL,
	[registrado_por] [uniqueidentifier] NOT NULL,
	[fecha_registro] [datetime] NOT NULL,
 CONSTRAINT [PK_pol_poliza_x_cliente] PRIMARY KEY CLUSTERED 
(
	[pol_poliza] ASC,
	[crm_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[POL_TIPO_CUBRIMIENTO]    Script Date: 23/8/2019 1:01:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POL_TIPO_CUBRIMIENTO](
	[pol_tipo_cubrimiento] [uniqueidentifier] NOT NULL,
	[nombre] [varchar](250) NOT NULL,
	[cobertura] [decimal](5, 2) NOT NULL,
	[activo] [bit] NOT NULL,
 CONSTRAINT [PK_POL_TIPO_CUBRIMIENTO] PRIMARY KEY CLUSTERED 
(
	[pol_tipo_cubrimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[POL_TIPO_RIESGO]    Script Date: 23/8/2019 1:01:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POL_TIPO_RIESGO](
	[pol_tipo_riesgo] [uniqueidentifier] NOT NULL,
	[tipo_riesgo] [varchar](100) NOT NULL,
	[activo] [bit] NOT NULL,
	[cobertura_maxima] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_POL_TIPO_RIESGO] PRIMARY KEY CLUSTERED 
(
	[pol_tipo_riesgo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[POL_TIPO_RIESGO] ADD  CONSTRAINT [DF_POL_TIPO_RIESGO_cobertura_maxima]  DEFAULT ((100)) FOR [cobertura_maxima]
GO
ALTER TABLE [dbo].[POL_POLIZA]  WITH CHECK ADD  CONSTRAINT [FK_POL_POLIZA_POL_TIPO_CUBRIMIENTO] FOREIGN KEY([pol_tipo_cubrimiento])
REFERENCES [dbo].[POL_TIPO_CUBRIMIENTO] ([pol_tipo_cubrimiento])
GO
ALTER TABLE [dbo].[POL_POLIZA] CHECK CONSTRAINT [FK_POL_POLIZA_POL_TIPO_CUBRIMIENTO]
GO
ALTER TABLE [dbo].[POL_POLIZA]  WITH CHECK ADD  CONSTRAINT [FK_POL_POLIZA_POL_TIPO_RIESGO] FOREIGN KEY([pol_tipo_riesgo])
REFERENCES [dbo].[POL_TIPO_RIESGO] ([pol_tipo_riesgo])
GO
ALTER TABLE [dbo].[POL_POLIZA] CHECK CONSTRAINT [FK_POL_POLIZA_POL_TIPO_RIESGO]
GO
ALTER TABLE [dbo].[POL_POLIZA_X_CLIENTE]  WITH CHECK ADD  CONSTRAINT [FK_POL_POLIZA_X_CLIENTE_CRM_CLIENTE] FOREIGN KEY([crm_cliente])
REFERENCES [dbo].[CRM_CLIENTE] ([crm_cliente])
GO
ALTER TABLE [dbo].[POL_POLIZA_X_CLIENTE] CHECK CONSTRAINT [FK_POL_POLIZA_X_CLIENTE_CRM_CLIENTE]
GO
ALTER TABLE [dbo].[POL_POLIZA_X_CLIENTE]  WITH CHECK ADD  CONSTRAINT [FK_POL_POLIZA_X_CLIENTE_POL_POLIZA] FOREIGN KEY([pol_poliza])
REFERENCES [dbo].[POL_POLIZA] ([pol_poliza])
GO
ALTER TABLE [dbo].[POL_POLIZA_X_CLIENTE] CHECK CONSTRAINT [FK_POL_POLIZA_X_CLIENTE_POL_POLIZA]
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_CRM_CLIENTE]    Script Date: 23/8/2019 1:01:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/***************
* Procedimiento: [PA_CONS_CRM_CLIENTE]
* Autor: jose.alberto.leiva
* Fecha: 20/08/2019
* Descripción:
*
*
* Historia de cambios
* Fecha			Autor			Ref.			Descripcion
* 
***************/
CREATE PROCEDURE [dbo].[PA_CONS_CRM_CLIENTE] @ESTADO VARCHAR(2) = '00' OUTPUT
	, @MENSAJE VARCHAR(250) = '' OUTPUT
AS
BEGIN
	BEGIN TRY
		SELECT crm_cliente
			, nombre_completo
			, correo_electronico
		FROM CRM_CLIENTE

		SELECT @ESTADO = '00'
			, @MENSAJE = ''
	END TRY

	BEGIN CATCH
		SELECT @ESTADO = '99'
			, @MENSAJE = ''

		SELECT @ESTADO = '99'
			, @MENSAJE = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_POL_POLIZA]    Script Date: 23/8/2019 1:01:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/***************
* Procedimiento: PA_CONS_POL_POLIZA
* Autor: jose.alberto.leiva
* Fecha: 20/08/2019
* Descripción:
*
*
* Historia de cambios
* Fecha			Autor			Ref.			Descripcion
* 
***************/
CREATE PROCEDURE [dbo].[PA_CONS_POL_POLIZA] @ESTADO VARCHAR(2) = '00' OUTPUT
	, @MENSAJE VARCHAR(250) = '' OUTPUT
AS
BEGIN
	BEGIN TRY
		SELECT POL_POLIZA.pol_poliza
			, POL_POLIZA.nombre
			, POL_POLIZA.pol_tipo_cubrimiento
			, POL_POLIZA.descripcion
			, POL_POLIZA.inicio_vigencia
			, convert(varchar(20),POL_POLIZA.inicio_vigencia,103) as inicio_vigencia_formato
			, POL_POLIZA.periodo_cobertura
			, POL_POLIZA.precio
			, POL_POLIZA.pol_tipo_riesgo
			, POL_TIPO_CUBRIMIENTO.nombre AS cubrimiento
			, POL_TIPO_RIESGO.tipo_riesgo
			, POL_TIPO_RIESGO.cobertura_maxima
		FROM POL_POLIZA
		INNER JOIN POL_TIPO_CUBRIMIENTO
			ON POL_POLIZA.pol_tipo_cubrimiento = POL_TIPO_CUBRIMIENTO.pol_tipo_cubrimiento
		INNER JOIN POL_TIPO_RIESGO
			ON POL_POLIZA.pol_tipo_riesgo = POL_TIPO_RIESGO.pol_tipo_riesgo

		SELECT @ESTADO = '00'
			, @MENSAJE = ''
	END TRY

	BEGIN CATCH
		SELECT @ESTADO = '99'
			, @MENSAJE = ''

		SELECT @ESTADO = '99'
			, @MENSAJE = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_POL_POLIZA_X_CLIENTE]    Script Date: 23/8/2019 1:01:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/***************
* Procedimiento: PA_CONS_POL_POLIZA_X_CLIENTE
* Autor: jose.alberto.leiva
* Fecha: 20/08/2019
* Descripción:
*
*
* Historia de cambios
* Fecha			Autor			Ref.			Descripcion
* 
***************/
CREATE PROCEDURE [dbo].[PA_CONS_POL_POLIZA_X_CLIENTE] @p_crm_cliente UNIQUEIDENTIFIER
	, @ESTADO VARCHAR(2) = '00' OUTPUT
	, @MENSAJE VARCHAR(250) = '' OUTPUT
AS
BEGIN
	BEGIN TRY
		SELECT POL_POLIZA_X_CLIENTE.pol_poliza
			, POL_POLIZA_X_CLIENTE.crm_cliente
			, POL_POLIZA_X_CLIENTE.registrado_por
			, POL_POLIZA_X_CLIENTE.fecha_registro
			, POL_POLIZA.nombre
			, CRM_CLIENTE.nombre_completo
			, POL_TIPO_RIESGO.tipo_riesgo
			, POL_TIPO_CUBRIMIENTO.nombre AS tipo_cubrimiento
		FROM POL_POLIZA_X_CLIENTE
		INNER JOIN POL_POLIZA
			ON POL_POLIZA_X_CLIENTE.pol_poliza = POL_POLIZA.pol_poliza
		INNER JOIN CRM_CLIENTE
			ON POL_POLIZA_X_CLIENTE.crm_cliente = CRM_CLIENTE.crm_cliente
		INNER JOIN POL_TIPO_CUBRIMIENTO
			ON POL_POLIZA.pol_tipo_cubrimiento = POL_TIPO_CUBRIMIENTO.pol_tipo_cubrimiento
		INNER JOIN POL_TIPO_RIESGO
			ON POL_POLIZA.pol_tipo_riesgo = POL_TIPO_RIESGO.pol_tipo_riesgo
		WHERE (POL_POLIZA_X_CLIENTE.crm_cliente = @p_crm_cliente)

		SELECT @ESTADO = '00'
			, @MENSAJE = ''
	END TRY

	BEGIN CATCH
		SELECT @ESTADO = '99'
			, @MENSAJE = ''

		SELECT @ESTADO = '99'
			, @MENSAJE = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_POL_POLIZA_X_CLIENTE_X_ID]    Script Date: 23/8/2019 1:01:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/***************
* Procedimiento: [PA_CONS_POL_POLIZA_X_CLIENTE_X_ID]
* Autor: jose.alberto.leiva
* Fecha: 20/08/2019
* Descripción:
*
*
* Historia de cambios
* Fecha			Autor			Ref.			Descripcion
* 
***************/
CREATE PROCEDURE [dbo].[PA_CONS_POL_POLIZA_X_CLIENTE_X_ID] @p_crm_cliente UNIQUEIDENTIFIER
	, @p_pol_poliza UNIQUEIDENTIFIER
	, @ESTADO VARCHAR(2) = '00' OUTPUT
	, @MENSAJE VARCHAR(250) = '' OUTPUT
AS
BEGIN
	BEGIN TRY
		
		SELECT POL_POLIZA_X_CLIENTE.pol_poliza
			, POL_POLIZA_X_CLIENTE.crm_cliente
			, POL_POLIZA_X_CLIENTE.registrado_por
			, POL_POLIZA_X_CLIENTE.fecha_registro
			, POL_POLIZA.nombre
			, CRM_CLIENTE.nombre_completo
			, POL_TIPO_RIESGO.tipo_riesgo
			, POL_TIPO_CUBRIMIENTO.nombre AS tipo_cubrimiento
		FROM POL_POLIZA_X_CLIENTE
		INNER JOIN POL_POLIZA
			ON POL_POLIZA_X_CLIENTE.pol_poliza = POL_POLIZA.pol_poliza
		INNER JOIN CRM_CLIENTE
			ON POL_POLIZA_X_CLIENTE.crm_cliente = CRM_CLIENTE.crm_cliente
		INNER JOIN POL_TIPO_CUBRIMIENTO
			ON POL_POLIZA.pol_tipo_cubrimiento = POL_TIPO_CUBRIMIENTO.pol_tipo_cubrimiento
		INNER JOIN POL_TIPO_RIESGO
			ON POL_POLIZA.pol_tipo_riesgo = POL_TIPO_RIESGO.pol_tipo_riesgo
		WHERE (POL_POLIZA_X_CLIENTE.crm_cliente = @p_crm_cliente)
		and (POL_POLIZA_X_CLIENTE.pol_poliza = @p_pol_poliza)

		SELECT @ESTADO = '00'
			, @MENSAJE = ''
	END TRY

	BEGIN CATCH
		SELECT @ESTADO = '99'
			, @MENSAJE = ''

		SELECT @ESTADO = '99'
			, @MENSAJE = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_POL_POLIZA_X_ID]    Script Date: 23/8/2019 1:01:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/***************
* Procedimiento: PA_CONS_POL_POLIZA
* Autor: jose.alberto.leiva
* Fecha: 20/08/2019
* Descripción:
*
*
* Historia de cambios
* Fecha			Autor			Ref.			Descripcion
* 
***************/
CREATE PROCEDURE [dbo].[PA_CONS_POL_POLIZA_X_ID] @pol_poliza uniqueidentifier
	,@ESTADO VARCHAR(2) = '00' OUTPUT
	, @MENSAJE VARCHAR(250) = '' OUTPUT
AS
BEGIN
	BEGIN TRY
		SELECT POL_POLIZA.pol_poliza
			, POL_POLIZA.nombre
			, POL_POLIZA.pol_tipo_cubrimiento
			, POL_POLIZA.descripcion
			, POL_POLIZA.inicio_vigencia
			, convert(varchar(20),POL_POLIZA.inicio_vigencia,103) as inicio_vigencia_formato
			, POL_POLIZA.periodo_cobertura
			, POL_POLIZA.precio
			, POL_POLIZA.pol_tipo_riesgo
			, POL_TIPO_CUBRIMIENTO.nombre AS cubrimiento
			, POL_TIPO_RIESGO.tipo_riesgo
			, POL_TIPO_RIESGO.cobertura_maxima
		FROM POL_POLIZA
		INNER JOIN POL_TIPO_CUBRIMIENTO
			ON POL_POLIZA.pol_tipo_cubrimiento = POL_TIPO_CUBRIMIENTO.pol_tipo_cubrimiento
		INNER JOIN POL_TIPO_RIESGO
			ON POL_POLIZA.pol_tipo_riesgo = POL_TIPO_RIESGO.pol_tipo_riesgo
		WHERE POL_POLIZA.pol_poliza=@pol_poliza;

		SELECT @ESTADO = '00'
			, @MENSAJE = ''
	END TRY

	BEGIN CATCH
		SELECT @ESTADO = '99'
			, @MENSAJE = ''

		SELECT @ESTADO = '99'
			, @MENSAJE = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_POL_TIPO_CUBRIMIENTO]    Script Date: 23/8/2019 1:01:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/***************
* Procedimiento: PA_CONS_POL_TIPO_CUBRIMIENTO
* Autor: jose.alberto.leiva
* Fecha: 20/08/2019
* Descripción:
*
*
* Historia de cambios
* Fecha			Autor			Ref.			Descripcion
* 
***************/
 CREATE PROCEDURE [dbo].[PA_CONS_POL_TIPO_CUBRIMIENTO]

@ESTADO VARCHAR(2) = '00' OUTPUT,
@MENSAJE varchar(250) = '' OUTPUT
AS
BEGIN
BEGIN TRY
	SELECT 
		pol_tipo_cubrimiento,
		nombre,
		cobertura,
		activo 
	FROM [dbo].POL_TIPO_CUBRIMIENTO
	;
		
	SELECT @ESTADO='00',@MENSAJE=''
END TRY
BEGIN CATCH
	SELECT @ESTADO='99',@MENSAJE=''
	SELECT @ESTADO='99',@MENSAJE=ERROR_MESSAGE();
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[PA_CONS_POL_TIPO_RIESGO]    Script Date: 23/8/2019 1:01:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/***************
* Procedimiento: PA_CONS_POL_TIPO_RIESGO
* Autor: jose.alberto.leiva
* Fecha: 20/08/2019
* Descripción:
*
*
* Historia de cambios
* Fecha			Autor			Ref.			Descripcion
* 
***************/
 CREATE PROCEDURE [dbo].[PA_CONS_POL_TIPO_RIESGO]

@ESTADO VARCHAR(2) = '00' OUTPUT,
@MENSAJE varchar(250) = '' OUTPUT
AS
BEGIN
BEGIN TRY
	SELECT 
		pol_tipo_riesgo,
		tipo_riesgo,
		activo 
	FROM [dbo].POL_TIPO_RIESGO
	
		
	SELECT @ESTADO='00',@MENSAJE=''
END TRY
BEGIN CATCH
	SELECT @ESTADO='99',@MENSAJE=''
	SELECT @ESTADO='99',@MENSAJE=ERROR_MESSAGE();
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[PA_MANT_POL_POLIZA]    Script Date: 23/8/2019 1:01:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/***************
* Procedimiento: PA_MANT_POL_POLIZA
* Autor: jose.alberto.leiva
* Fecha: 20/08/2019
* Descripción:
*
*
* Historia de cambios
* Fecha			Autor			Ref.			Descripcion
* 
***************/
CREATE PROCEDURE [dbo].[PA_MANT_POL_POLIZA] @p_tipo_operacion INT
	, @p_pol_poliza UNIQUEIDENTIFIER
	, @p_nombre VARCHAR(100)
	, @p_pol_tipo_cubrimiento UNIQUEIDENTIFIER
	, @p_descripcion VARCHAR(250)
	, @p_inicio_vigencia DATETIME
	, @p_periodo_cobertura INT
	, @p_precio DECIMAL
	, @p_pol_tipo_riesgo UNIQUEIDENTIFIER
	, @ESTADO VARCHAR(2) = '00' OUTPUT
	, @MENSAJE VARCHAR(250) = '' OUTPUT
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		
		DECLARE @cobertura decimal(5,2);
		DECLARE @cobertura_maxima decimal(5,2);

		SELECT @cobertura=[cobertura]
		FROM [dbo].[POL_TIPO_CUBRIMIENTO]
		WHERE [pol_tipo_cubrimiento]=@p_pol_tipo_cubrimiento

		SELECT @cobertura_maxima = [cobertura_maxima]
		FROM [dbo].[POL_TIPO_RIESGO]
		WHERE [pol_tipo_riesgo]=@p_pol_tipo_riesgo
		SELECT @ESTADO = '00'
			, @MENSAJE = '';
		--Verifica si la cobertura no supera el máximo
		IF @cobertura >= @cobertura_maxima
		BEGIN
			SELECT @ESTADO = '98'
			, @MENSAJE = 'La cobertura supera el máximo permitido para el tipo de riesgo.';
		END
		ELSE IF @p_tipo_operacion = 1
		BEGIN
			INSERT INTO POL_POLIZA (
				pol_poliza
				, nombre
				, pol_tipo_cubrimiento
				, descripcion
				, inicio_vigencia
				, periodo_cobertura
				, precio
				, pol_tipo_riesgo
				)
			VALUES (
				@p_pol_poliza
				, @p_nombre
				, @p_pol_tipo_cubrimiento
				, @p_descripcion
				, @p_inicio_vigencia
				, @p_periodo_cobertura
				, @p_precio
				, @p_pol_tipo_riesgo
				)
		END;
		ELSE IF @p_tipo_operacion = 2
		BEGIN
			UPDATE [dbo].POL_POLIZA
			SET pol_poliza = @p_pol_poliza
				, nombre = @p_nombre
				, pol_tipo_cubrimiento = @p_pol_tipo_cubrimiento
				, descripcion = @p_descripcion
				, inicio_vigencia = @p_inicio_vigencia
				, periodo_cobertura = @p_periodo_cobertura
				, precio = @p_precio
				, pol_tipo_riesgo = @p_pol_tipo_riesgo
			WHERE pol_poliza = @p_pol_poliza
		END;
		ELSE IF @p_tipo_operacion = 3
		BEGIN
			DELETE POL_POLIZA
			WHERE pol_poliza = @p_pol_poliza
		END;

		

		COMMIT TRANSACTION;
	END TRY

	BEGIN CATCH
		SELECT @ESTADO = '99'
			, @MENSAJE = ''

		ROLLBACK TRANSACTION;

		SELECT @ESTADO = '99'
			, @MENSAJE = 'No se ha realizado la operación. Por favor verifique los datos ingresados.';
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[PA_MANT_POL_POLIZA_X_CLIENTE]    Script Date: 23/8/2019 1:01:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



/***************
* Procedimiento: PA_MANT_POL_POLIZA_X_CLIENTE
* Autor: jose.alberto.leiva
* Fecha: 20/08/2019
* Descripción:
*
*
* Historia de cambios
* Fecha			Autor			Ref.			Descripcion
* 
***************/
CREATE PROCEDURE [dbo].[PA_MANT_POL_POLIZA_X_CLIENTE] @p_tipo_operacion INT
	, @p_pol_poliza UNIQUEIDENTIFIER
	, @p_crm_cliente UNIQUEIDENTIFIER
	, @p_nombre_cliente VARCHAR(100)
	, @p_correo_cliente VARCHAR(100)
	, @p_registrado_por UNIQUEIDENTIFIER
	, @p_fecha_registro DATETIME
	, @ESTADO VARCHAR(2) = '00' OUTPUT
	, @MENSAJE VARCHAR(250) = '' OUTPUT
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION


		IF @p_tipo_operacion = 1
		BEGIN
			INSERT INTO POL_POLIZA_X_CLIENTE (
				pol_poliza
				, crm_cliente
				, registrado_por
				, fecha_registro
				)
			VALUES (
				@p_pol_poliza
				, @p_crm_cliente
				, @p_registrado_por
				, @p_fecha_registro
				)
		END;
		ELSE IF @p_tipo_operacion = 2
		BEGIN
			UPDATE [dbo].POL_POLIZA_X_CLIENTE
			SET pol_poliza = @p_pol_poliza
				, crm_cliente = @p_crm_cliente
				, registrado_por = @p_registrado_por
				, fecha_registro = @p_fecha_registro
			WHERE pol_poliza = @p_pol_poliza
				AND crm_cliente = @p_crm_cliente
		END;
		ELSE IF @p_tipo_operacion = 3
		BEGIN
			DELETE POL_POLIZA_X_CLIENTE
			WHERE pol_poliza = @p_pol_poliza
				AND crm_cliente = @p_crm_cliente
		END;

		SELECT @ESTADO = '00'
			, @MENSAJE = ''

		COMMIT TRANSACTION;
	END TRY

	BEGIN CATCH
		SELECT @ESTADO = '99'
			, @MENSAJE = ''

		ROLLBACK TRANSACTION;

		SELECT @ESTADO = '99'
			, @MENSAJE = 'No se ha realizado la operación. Por favor verifique los datos ingresados.';;
	END CATCH
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Período de cobertura en meses' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'POL_POLIZA', @level2type=N'COLUMN',@level2name=N'periodo_cobertura'
GO
