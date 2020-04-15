CREATE DATABASE  IF NOT EXISTS `mydb` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mydb`;
-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mydb
-- ------------------------------------------------------
-- Server version	8.0.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `acreedor`
--

DROP TABLE IF EXISTS `acreedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `acreedor` (
  `pkidacreedor` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `telefono` int(11) DEFAULT NULL,
  `nit` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `calidadservicio` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkidacreedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acreedor`
--

LOCK TABLES `acreedor` WRITE;
/*!40000 ALTER TABLE `acreedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `acreedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bodega`
--

DROP TABLE IF EXISTS `bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bodega` (
  `pkidBodega` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Telefono` int(11) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `StockMaximo` int(11) DEFAULT NULL,
  `StockMinimo` int(11) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkidBodega`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bodega`
--

LOCK TABLES `bodega` WRITE;
/*!40000 ALTER TABLE `bodega` DISABLE KEYS */;
/*!40000 ALTER TABLE `bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleado` (
  `pkIdEmpleado` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkIdEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES (1,'JOSE'),(2,'ALEJANDRO'),(3,'VLADIMIR');
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturaproveedordetalle`
--

DROP TABLE IF EXISTS `facturaproveedordetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `facturaproveedordetalle` (
  `pkidDetalleFactura` int(11) NOT NULL AUTO_INCREMENT,
  `fkidEncabezadoFactura` int(11) DEFAULT NULL,
  `fkidProducto` int(11) DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `precioUnitario` double DEFAULT NULL,
  `subTotal` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidDetalleFactura`),
  KEY `fk_facturaProveedorDetalle_facturaProveedorEncabezado1_idx` (`fkidEncabezadoFactura`),
  KEY `fk_facturaProveedorDetalle_producto1_idx` (`fkidProducto`),
  CONSTRAINT `fk_facturaProveedorDetalle_facturaProveedorEncabezado1` FOREIGN KEY (`fkidEncabezadoFactura`) REFERENCES `facturaproveedorencabezado` (`pkidEncabezadoFacturaP`),
  CONSTRAINT `fk_facturaProveedorDetalle_producto1` FOREIGN KEY (`fkidProducto`) REFERENCES `producto` (`pkidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturaproveedordetalle`
--

LOCK TABLES `facturaproveedordetalle` WRITE;
/*!40000 ALTER TABLE `facturaproveedordetalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `facturaproveedordetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturaproveedorencabezado`
--

DROP TABLE IF EXISTS `facturaproveedorencabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `facturaproveedorencabezado` (
  `pkidEncabezadoFacturaP` int(11) NOT NULL,
  `fkIdOrdenCompra` int(11) DEFAULT NULL,
  `fkidEmpleado` int(11) DEFAULT NULL,
  `segun` varchar(45) DEFAULT NULL,
  `serieFactura` varchar(45) DEFAULT NULL,
  `numeroFactura` varchar(45) DEFAULT NULL,
  `fechaEntrega` date DEFAULT NULL,
  `fkIdImpuesto` int(11) DEFAULT NULL,
  `totalImpuesto` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidEncabezadoFacturaP`),
  KEY `fk_facturaProveedorEncabezado_empleado1_idx` (`fkidEmpleado`),
  KEY `fk_facturaproveedorencabezado_ordenComrpaEncabezado1_idx` (`fkIdOrdenCompra`),
  KEY `fk_facturaproveedorencabezado_impuestos1_idx` (`fkIdImpuesto`),
  CONSTRAINT `fk_facturaProveedorEncabezado_empleado1` FOREIGN KEY (`fkidEmpleado`) REFERENCES `empleado` (`pkIdEmpleado`),
  CONSTRAINT `fk_facturaproveedorencabezado_impuestos1` FOREIGN KEY (`fkIdImpuesto`) REFERENCES `impuestos` (`pkidImpuesto`),
  CONSTRAINT `fk_facturaproveedorencabezado_ordenComrpaEncabezado1` FOREIGN KEY (`fkIdOrdenCompra`) REFERENCES `ordencomrpaencabezado` (`pkIdOrdenCompraEncabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturaproveedorencabezado`
--

LOCK TABLES `facturaproveedorencabezado` WRITE;
/*!40000 ALTER TABLE `facturaproveedorencabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `facturaproveedorencabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formaspago`
--

DROP TABLE IF EXISTS `formaspago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `formaspago` (
  `pkIdFormaPago` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkIdFormaPago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formaspago`
--

LOCK TABLES `formaspago` WRITE;
/*!40000 ALTER TABLE `formaspago` DISABLE KEYS */;
INSERT INTO `formaspago` VALUES (1,'efectivo','dinero',1),(2,'tarjeta','plastico',1),(3,'cheque','papel',1);
/*!40000 ALTER TABLE `formaspago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `impuestos`
--

DROP TABLE IF EXISTS `impuestos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `impuestos` (
  `pkidImpuesto` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `valor` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidImpuesto`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `impuestos`
--

LOCK TABLES `impuestos` WRITE;
/*!40000 ALTER TABLE `impuestos` DISABLE KEYS */;
INSERT INTO `impuestos` VALUES (1,'IVA','por comprar',0.12,1),(2,'IVA','por pagar',0.6,1);
/*!40000 ALTER TABLE `impuestos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento_detalle`
--

DROP TABLE IF EXISTS `movimiento_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimiento_detalle` (
  `Linea` int(11) NOT NULL AUTO_INCREMENT,
  `pkidMovimiento` int(11) NOT NULL,
  `pkidmovimiento_general` int(11) NOT NULL,
  PRIMARY KEY (`Linea`,`pkidMovimiento`,`pkidmovimiento_general`),
  KEY `fk_movimiento_detalle_movimiento_encabezado1_idx` (`pkidMovimiento`),
  KEY `fk_movimiento_detalle_movimiento_general1_idx` (`pkidmovimiento_general`),
  CONSTRAINT `fk_movimiento_detalle_movimiento_encabezado1` FOREIGN KEY (`pkidMovimiento`) REFERENCES `movimiento_encabezado` (`pkidMovimiento`),
  CONSTRAINT `fk_movimiento_detalle_movimiento_general1` FOREIGN KEY (`pkidmovimiento_general`) REFERENCES `movimiento_general` (`pkidmovimiento_general`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento_detalle`
--

LOCK TABLES `movimiento_detalle` WRITE;
/*!40000 ALTER TABLE `movimiento_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimiento_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento_encabezado`
--

DROP TABLE IF EXISTS `movimiento_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimiento_encabezado` (
  `pkidMovimiento` int(11) NOT NULL,
  `idEmpleado` int(11) NOT NULL,
  `Fecha` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidMovimiento`,`idEmpleado`),
  KEY `fk_movimiento_encabezado_empleado1_idx` (`idEmpleado`),
  CONSTRAINT `fk_movimiento_encabezado_empleado1` FOREIGN KEY (`idEmpleado`) REFERENCES `empleado` (`pkIdEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento_encabezado`
--

LOCK TABLES `movimiento_encabezado` WRITE;
/*!40000 ALTER TABLE `movimiento_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimiento_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento_general`
--

DROP TABLE IF EXISTS `movimiento_general`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimiento_general` (
  `pkidmovimiento_general` int(11) NOT NULL,
  `pkidProducto` int(11) DEFAULT NULL,
  `concepto` varchar(45) DEFAULT NULL,
  `documento` varchar(45) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`pkidmovimiento_general`),
  KEY `fk_movimiento_general_producto1_idx` (`pkidProducto`),
  CONSTRAINT `fk_movimiento_general_producto1` FOREIGN KEY (`pkidProducto`) REFERENCES `producto` (`pkidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento_general`
--

LOCK TABLES `movimiento_general` WRITE;
/*!40000 ALTER TABLE `movimiento_general` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimiento_general` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordencompradetalle`
--

DROP TABLE IF EXISTS `ordencompradetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ordencompradetalle` (
  `pkIdCompraDetalle` int(11) NOT NULL,
  `fkIdordenCompraEncabezado` int(11) DEFAULT NULL,
  `codigoLinea` int(11) NOT NULL AUTO_INCREMENT,
  `fkIdProducto` int(11) DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `subTotal` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`codigoLinea`,`pkIdCompraDetalle`),
  KEY `fk_ordenCompraDetalle_ordenComrpaEncabezado1_idx` (`fkIdordenCompraEncabezado`),
  KEY `fk_ordenCompraDetalle_producto1_idx` (`fkIdProducto`),
  CONSTRAINT `fk_ordenCompraDetalle_ordenComrpaEncabezado1` FOREIGN KEY (`fkIdordenCompraEncabezado`) REFERENCES `ordencomrpaencabezado` (`pkIdOrdenCompraEncabezado`),
  CONSTRAINT `fk_ordenCompraDetalle_producto1` FOREIGN KEY (`fkIdProducto`) REFERENCES `producto` (`pkidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordencompradetalle`
--

LOCK TABLES `ordencompradetalle` WRITE;
/*!40000 ALTER TABLE `ordencompradetalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `ordencompradetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordencomrpaencabezado`
--

DROP TABLE IF EXISTS `ordencomrpaencabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ordencomrpaencabezado` (
  `pkIdOrdenCompraEncabezado` int(11) NOT NULL,
  `fkIdProveedor` int(11) DEFAULT NULL,
  `fkIdFormaPago` int(11) DEFAULT NULL,
  `fechaPedido` date DEFAULT NULL,
  `fechaRequerida` date DEFAULT NULL,
  `fkIdEmpleado` int(11) DEFAULT NULL,
  `observaciones` varchar(45) DEFAULT NULL,
  `totalImpuesto` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `descuento` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkIdOrdenCompraEncabezado`),
  KEY `fk_ordenComrpaEncabezado_formasPago1_idx` (`fkIdFormaPago`),
  KEY `fk_ordenComrpaEncabezado_empleado1_idx` (`fkIdEmpleado`),
  KEY `fk_ordenComrpaEncabezado_proveedor1_idx` (`fkIdProveedor`),
  CONSTRAINT `fk_ordenComrpaEncabezado_empleado1` FOREIGN KEY (`fkIdEmpleado`) REFERENCES `empleado` (`pkIdEmpleado`),
  CONSTRAINT `fk_ordenComrpaEncabezado_formasPago1` FOREIGN KEY (`fkIdFormaPago`) REFERENCES `formaspago` (`pkIdFormaPago`),
  CONSTRAINT `fk_ordenComrpaEncabezado_proveedor1` FOREIGN KEY (`fkIdProveedor`) REFERENCES `proveedor` (`pkidProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordencomrpaencabezado`
--

LOCK TABLES `ordencomrpaencabezado` WRITE;
/*!40000 ALTER TABLE `ordencomrpaencabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `ordencomrpaencabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `pkidProveedor` int(11) NOT NULL,
  `pkidProducto` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Precio` decimal(3,0) DEFAULT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Presentacion` varchar(45) DEFAULT NULL,
  `Costo` int(11) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  `pktipo_producto` int(11) NOT NULL,
  PRIMARY KEY (`pkidProducto`,`pkidProveedor`),
  KEY `fk_Producto_Tipo Producto1_idx` (`pktipo_producto`),
  KEY `fk_Producto_Proveedor1_idx` (`pkidProveedor`),
  CONSTRAINT `fk_Producto_Proveedor1` FOREIGN KEY (`pkidProveedor`) REFERENCES `proveedor` (`pkidProveedor`),
  CONSTRAINT `fk_Producto_Tipo Producto1` FOREIGN KEY (`pktipo_producto`) REFERENCES `tipo producto` (`pktipo_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,1,'Jabon',50,'Para limpiar','barra',30,1,1),(1,2,'Shampoo',60,'Para limpiar','botella',45,1,1);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productoenbodega`
--

DROP TABLE IF EXISTS `productoenbodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productoenbodega` (
  `Bodega_idBodega` int(11) NOT NULL,
  `Producto_idProducto` int(11) NOT NULL,
  `Existencias` int(11) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Bodega_idBodega`,`Producto_idProducto`),
  KEY `fk_ProductoenBodega_Bodega1_idx` (`Bodega_idBodega`),
  KEY `fk_ProductoenBodega_Producto1_idx` (`Producto_idProducto`),
  CONSTRAINT `fk_ProductoenBodega_Bodega1` FOREIGN KEY (`Bodega_idBodega`) REFERENCES `bodega` (`pkidBodega`),
  CONSTRAINT `fk_ProductoenBodega_Producto1` FOREIGN KEY (`Producto_idProducto`) REFERENCES `producto` (`pkidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productoenbodega`
--

LOCK TABLES `productoenbodega` WRITE;
/*!40000 ALTER TABLE `productoenbodega` DISABLE KEYS */;
/*!40000 ALTER TABLE `productoenbodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedor` (
  `pkidProveedor` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Nit` int(11) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Telefono` int(11) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkidProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,'JUAN',13131,'ZONA 7',4444,'adfa@correo.com',1),(2,'PEDRO',3131,'ZONA 10',56565,'hlhlh@correo.com',1);
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ruta`
--

DROP TABLE IF EXISTS `ruta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ruta` (
  `pkidruta` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkidruta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ruta`
--

LOCK TABLES `ruta` WRITE;
/*!40000 ALTER TABLE `ruta` DISABLE KEYS */;
/*!40000 ALTER TABLE `ruta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sucursal`
--

DROP TABLE IF EXISTS `sucursal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sucursal` (
  `pkidsucursal` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkidsucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sucursal`
--

LOCK TABLES `sucursal` WRITE;
/*!40000 ALTER TABLE `sucursal` DISABLE KEYS */;
/*!40000 ALTER TABLE `sucursal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo producto`
--

DROP TABLE IF EXISTS `tipo producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo producto` (
  `pktipo_producto` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pktipo_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo producto`
--

LOCK TABLES `tipo producto` WRITE;
/*!40000 ALTER TABLE `tipo producto` DISABLE KEYS */;
INSERT INTO `tipo producto` VALUES (1,'Venta','Para vender',1),(2,'Materia Prima','Para crear',1);
/*!40000 ALTER TABLE `tipo producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipobodega`
--

DROP TABLE IF EXISTS `tipobodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipobodega` (
  `pkidtipobodega` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `capacidad` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkidtipobodega`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipobodega`
--

LOCK TABLES `tipobodega` WRITE;
/*!40000 ALTER TABLE `tipobodega` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipobodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipotransporte`
--

DROP TABLE IF EXISTS `tipotransporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipotransporte` (
  `pkidtipotransporte` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `capacidad` float DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkidtipotransporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipotransporte`
--

LOCK TABLES `tipotransporte` WRITE;
/*!40000 ALTER TABLE `tipotransporte` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipotransporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transporte`
--

DROP TABLE IF EXISTS `transporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transporte` (
  `pkidtransporte` int(11) NOT NULL AUTO_INCREMENT,
  `fkidruta` int(11) NOT NULL,
  `fkidtipotransporte` int(11) NOT NULL,
  `placa` varchar(45) DEFAULT NULL,
  `chasis` varchar(45) DEFAULT NULL,
  `motor` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkidtransporte`),
  KEY `fk_transporte_ruta1_idx` (`fkidruta`),
  KEY `fk_transporte_tipotransporte1_idx` (`fkidtipotransporte`),
  CONSTRAINT `fk_transporte_ruta1` FOREIGN KEY (`fkidruta`) REFERENCES `ruta` (`pkidruta`),
  CONSTRAINT `fk_transporte_tipotransporte1` FOREIGN KEY (`fkidtipotransporte`) REFERENCES `tipotransporte` (`pkidtipotransporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transporte`
--

LOCK TABLES `transporte` WRITE;
/*!40000 ALTER TABLE `transporte` DISABLE KEYS */;
/*!40000 ALTER TABLE `transporte` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-04-14 19:49:38
