Delete  from errorlist where inactivo = 1;
Delete  from Roles where Inactivo = 1;
Delete  from Usuarios where Inactivo = 1;
--Select *  from LogEventos ;
Delete  from OpcionesSist where Inactivo = 1;
Delete  from PermisosRol where Inactivo = 1;
Delete  from Mesas where Inactivo = 1;
Delete  from Monedas where Inactivo = 1;
Delete  from formaPagos where Inactivo = 1;
Delete  from Categorias where Inactivo = 1;
Delete  from Productos where Inactivo = 1;
Delete  from OrderDetails where Inactivo = 1;
Delete  from OrderHeaders where Inactivo = 1;

/*
 Revision
 select * from OrderDetails where OrderHID not in (select ID from OrderHeaders )
 select * from OrderDetails where OrderHID  in (select ID from OrderHeaders)
*/