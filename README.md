📊 Sistema de Gestión de Inventarios y Reportería (Kardex)
Este proyecto es una solución integral diseñada para la gestión y auditoría de inventarios a gran escala, capaz de procesar más de 4,978 productos en tiempo real. La arquitectura está desacoplada en un frontend reactivo y un backend robusto configurado como servicio de sistema.

🚀 Arquitectura Técnica
Frontend: Desarrollado con Vue 3 y Vite, utilizando una interfaz reactiva para la visualización de KPIs financieros y movimientos de almacén.

Backend: API construida en C# (.NET), implementada como un Windows Service para garantizar alta disponibilidad y persistencia en el servidor.

Bases de Datos: Soporte híbrido para SQL Server y Oracle 21c, gestionando la lógica de negocio y validación de documentos fiscales.

Infraestructura: Despliegue sobre Windows Server y Linux (Debian), utilizando Cloudflare Tunnels (Zero Trust) para exposición segura de servicios y Tailscale/SSH para administración remota.

🛠️ Configuración del Entorno
Por seguridad, los archivos de configuración con credenciales reales están excluidos del repositorio. Siga estos pasos para la instalación local:

1. Backend (ReportesAPI)
Localice el archivo appsettings.Example.json.

Renómbrelo a appsettings.json.

Configure sus cadenas de conexión (ConnectionStrings) y su llave de firma para JWT.

2. Frontend (reportes)
Localice el archivo .env.example.

Renómbrelo a .env.

Defina la variable VITE_API_URL con la dirección de su API.

🛡️ Seguridad y Buenas Prácticas
Gestión de Secretos: Uso de interceptores en Axios para manejo automatizado de tokens Bearer JWT.

CORS Policy: Configuración de políticas de origen específicas para restringir el acceso solo a dominios autorizados.

Agnóstico a Red: Implementación mediante túneles para evitar la apertura de puertos vulnerables en el firewall.
