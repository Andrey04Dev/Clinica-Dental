-- phpMyAdmin SQL Dump
-- version 4.4.12
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 18-11-2017 a las 23:47:47
-- Versión del servidor: 5.6.25
-- Versión de PHP: 5.6.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_clinica`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_anamnesis`
--

CREATE TABLE IF NOT EXISTS `tbl_anamnesis` (
  `idtbl_anamnesis` int(11) NOT NULL,
  `medico_cabecera` varchar(45) NOT NULL,
  `tipo_sangre` varchar(45) NOT NULL,
  `persona_avisar` varchar(45) NOT NULL,
  `telefono_emergencia` int(11) NOT NULL,
  `direccion` varchar(165) NOT NULL,
  `parentesco` varchar(45) NOT NULL,
  `queja_principal` varchar(45) NOT NULL,
  `historia_queja_historia` varchar(45) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_anamnesis`
--

INSERT INTO `tbl_anamnesis` (`idtbl_anamnesis`, `medico_cabecera`, `tipo_sangre`, `persona_avisar`, `telefono_emergencia`, `direccion`, `parentesco`, `queja_principal`, `historia_queja_historia`) VALUES
(1, 'Jose Elizondo Marin', 'A+', 'Marinela Elizondo Marin', 87654345, 'rio claro', 'Madre', 'dientes', 'dientes');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_imagen`
--

CREATE TABLE IF NOT EXISTS `tbl_imagen` (
  `id_imagen` int(11) NOT NULL,
  `nombre_imagen` varchar(45) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_imagen`
--

INSERT INTO `tbl_imagen` (`id_imagen`, `nombre_imagen`) VALUES
(1, '123.jpg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_odontograma`
--

CREATE TABLE IF NOT EXISTS `tbl_odontograma` (
  `idtbl_odontograma` int(11) NOT NULL,
  `categoria_odontograma` varchar(45) NOT NULL,
  `imagen_odontograma` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_paciente`
--

CREATE TABLE IF NOT EXISTS `tbl_paciente` (
  `idtbl_paciente` int(11) NOT NULL,
  `cedula_paciente` varchar(9) NOT NULL,
  `nombre_paciente` varchar(20) NOT NULL,
  `apellido_paciente` varchar(45) NOT NULL,
  `telefono_paciente` int(8) NOT NULL,
  `direccion_paciente` varchar(165) NOT NULL,
  `edad_paciente` int(2) NOT NULL,
  `sexo_paciente` varchar(12) NOT NULL,
  `lugar_nacimiento` varchar(20) NOT NULL,
  `enfermedad_padecimiento` varchar(140) NOT NULL,
  `problema_presion` varchar(2) NOT NULL,
  `fiebre_reumatica` varchar(2) NOT NULL,
  `medico_cabecera` varchar(45) NOT NULL,
  `tipo_sangre` varchar(3) NOT NULL,
  `telefono_emergencia` int(8) NOT NULL,
  `parentesco` varchar(12) NOT NULL,
  `historia_queja_medica` varchar(45) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_paciente`
--

INSERT INTO `tbl_paciente` (`idtbl_paciente`, `cedula_paciente`, `nombre_paciente`, `apellido_paciente`, `telefono_paciente`, `direccion_paciente`, `edad_paciente`, `sexo_paciente`, `lugar_nacimiento`, `enfermedad_padecimiento`, `problema_presion`, `fiebre_reumatica`, `medico_cabecera`, `tipo_sangre`, `telefono_emergencia`, `parentesco`, `historia_queja_medica`) VALUES
(19, '765678987', 'ftyuifrgyu', 'dfghjk', 34567895, 'fghjkrty', 23, 'Masculino', 'dfgyudfghj', 'fghjfghjk', 'No', 'No', 'dfghjrfgh', 'A+', 56789876, 'ytrtyuiiuytr', 'fvgbhjkjhgfdfgh'),
(20, '604080304', 'Andrey', 'Elizondo Marin', 87492853, 'Rio Claro', 23, 'Masculino', 'Golfito', 'Ninguna', 'No', 'No', 'Rogelio Torres', 'O+', 84432965, 'Madre', 'Marinela Elizondo'),
(21, '604330333', 'Jafeth', 'Granados', 87466545, 'La Cuesta', 21, 'Masculino', 'Cuidad Neily', 'Ninguna', 'No', 'Si', 'Jose Elizondo', 'O+', 87446554, 'Madre', 'Gabriela Loaiza');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tratamiento`
--

CREATE TABLE IF NOT EXISTS `tbl_tratamiento` (
  `id_tratamiento` int(11) NOT NULL,
  `nombre_tratamiento` varchar(65) NOT NULL,
  `precio` int(6) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=93 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_tratamiento`
--

INSERT INTO `tbl_tratamiento` (`id_tratamiento`, `nombre_tratamiento`, `precio`) VALUES
(1, 'Examen Clinico Diagnóstico', 15000),
(2, 'Modelos de Estudio montados', 20000),
(3, 'Set Fotografia extra e intraorales', 15000),
(4, 'Interpretacion radiológica', 10000),
(5, 'Radiografías periapicales', 10000),
(6, 'Juego de 14 radiografías', 112000),
(7, 'Set de 4 aletas y 2 periapicales', 48000),
(8, 'Set de 4 aletas', 32000),
(9, 'Radiografía Panorámica', 22000),
(10, 'Radiografía Cefalométrica', 22000),
(11, 'Radiografía Oclusal', 15000),
(12, 'Radiovisiografía Digital', 16000),
(13, 'Ionomeros de vidrio', 12000),
(14, 'Bases para restauraciones', 12000),
(15, 'Oxido de zinc', 12000),
(16, 'Amalgamas 1 superficie', 15000),
(17, 'Amalgamas 2 superficies', 20000),
(18, 'Amalgamas  o más superficies', 26000),
(19, 'Resinas Clases I,III y V', 22000),
(20, 'Resinas Clases IV', 37000),
(21, 'Resinas Clases II 2 superficies', 29000),
(22, 'Resinas Clases II  o más superficies', 32000),
(23, 'Sellantes de fosas y fisuras por pieza', 18000),
(24, 'Blanqueo Fundas', 110000),
(25, 'Blanqueo Silla', 170000),
(26, 'Blanqueo por diente', 30000),
(27, 'Cierres de diastema', 36000),
(28, 'Carilla resina', 40000),
(29, 'Incrustaciones de resina compuesta indirecta', 73000),
(30, 'Recontorneo anatómico', 38000),
(31, 'Fracturas de dientes', 46000),
(32, 'Carillas de porcelana anteriores', 135000),
(33, 'Carillas de porcelana posteriores', 135000),
(34, 'Aleación base', 90000),
(35, 'Aleación contenido de metales nombles sin oro', 116000),
(36, 'Aleación contenido de metales nombles con oro', 158000),
(37, 'Porcelana', 125000),
(38, 'Cerómeros', 110000),
(39, 'Corona completa metal porcelana', 164000),
(40, 'Corona completa metálica', 103000),
(41, 'Corona completa oro amarillo', 156000),
(42, 'Corona completa metal porcelana', 145000),
(43, 'Coronas solo porcelana', 172000),
(44, 'Coronas completa Zirconio', 210000),
(45, 'Hombro de porcelana por corona', 20000),
(46, 'Prótesis removible metálico', 180000),
(47, 'Prótesis total superior o inferior', 112000),
(48, 'Prótesis parcial acrílica', 112000),
(49, 'Rebases inmediatos cualquier material', 70000),
(50, 'Rebases mediatos con laboratorio', 79000),
(51, 'Postes colados', 51000),
(52, 'Muñón sobre endoposte', 31000),
(53, 'Endopostes acero inoxidable', 26000),
(54, 'Endopostes titanio', 28000),
(55, 'Endopostes zirconio', 38000),
(56, 'Endopostes fibra de vidrio', 31000),
(57, 'Endodoncia uniradicular', 85000),
(58, 'Endodoncia biraducular', 100000),
(59, 'Endodoncia multiradicular', 125000),
(60, 'Endodoncia en piezas temporales', 35000),
(61, 'Apicectomías', 74000),
(62, 'Apicectomía + obturación retrógrada', 102000),
(63, 'Exodoncia', 20000),
(64, 'Exodoncia quirúrgica', 34000),
(65, 'Tratamiento de alveolitis por cita', 20000),
(66, 'Hemostasia alveolo periodontal', 26000),
(67, 'Enucleaciones', 34000),
(68, 'Regeneración con block colágeno', 56500),
(69, 'Regeneración con membrana reabsorobible', 155500),
(70, 'Regeneración con huesos banco 0,5 cc', 113500),
(71, 'Frenectomía', 60000),
(72, 'Sutura heridas mucosa oral', 60000),
(73, 'Remoción de cuerpo extraño', 51000),
(74, 'Profilaxis', 25000),
(75, 'Profilaxis y aplicación de flúor', 30000),
(76, 'Raspado manual por sesión', 25000),
(77, 'Raspado y alisado radicular manual por sesión', 30000),
(78, 'Raspado con ultrasonido', 30000),
(79, 'Alargamineto de corona', 49000),
(80, 'Instrucciones de fisioterapia oral', 15000),
(81, 'Coronas acero cromado', 30000),
(82, 'Amalgamas piezas temporales', 18000),
(83, 'Resina preventiva', 22000),
(84, 'Mantenedor banda y gaza', 55000),
(85, 'Arco Lingual', 70000),
(86, 'Arco', 74000),
(87, 'Exodoncia piezas temporales', 20000),
(88, 'Reposición de retenedor', 64000),
(89, 'Retenedores post tratamiento', 64000),
(90, 'Ortodoncia Fija', 1500),
(91, 'Consulta inicial peritajes', 85000),
(92, 'Ortodoncia interceptiva y correctiva', 287000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_users`
--

CREATE TABLE IF NOT EXISTS `tbl_users` (
  `idtbl_users` int(11) NOT NULL,
  `username` varchar(10) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_users`
--

INSERT INTO `tbl_users` (`idtbl_users`, `username`, `password`) VALUES
(1, 'Admin', 'Admin');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbl_anamnesis`
--
ALTER TABLE `tbl_anamnesis`
  ADD PRIMARY KEY (`idtbl_anamnesis`);

--
-- Indices de la tabla `tbl_imagen`
--
ALTER TABLE `tbl_imagen`
  ADD PRIMARY KEY (`id_imagen`);

--
-- Indices de la tabla `tbl_odontograma`
--
ALTER TABLE `tbl_odontograma`
  ADD PRIMARY KEY (`idtbl_odontograma`);

--
-- Indices de la tabla `tbl_paciente`
--
ALTER TABLE `tbl_paciente`
  ADD PRIMARY KEY (`idtbl_paciente`),
  ADD UNIQUE KEY `cedula_paciente_UNIQUE` (`cedula_paciente`);

--
-- Indices de la tabla `tbl_tratamiento`
--
ALTER TABLE `tbl_tratamiento`
  ADD PRIMARY KEY (`id_tratamiento`);

--
-- Indices de la tabla `tbl_users`
--
ALTER TABLE `tbl_users`
  ADD PRIMARY KEY (`idtbl_users`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tbl_anamnesis`
--
ALTER TABLE `tbl_anamnesis`
  MODIFY `idtbl_anamnesis` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `tbl_imagen`
--
ALTER TABLE `tbl_imagen`
  MODIFY `id_imagen` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `tbl_odontograma`
--
ALTER TABLE `tbl_odontograma`
  MODIFY `idtbl_odontograma` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tbl_paciente`
--
ALTER TABLE `tbl_paciente`
  MODIFY `idtbl_paciente` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT de la tabla `tbl_tratamiento`
--
ALTER TABLE `tbl_tratamiento`
  MODIFY `id_tratamiento` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=93;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
