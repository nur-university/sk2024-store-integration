# Shared Kernel - Integration

Este proyecto contiene los mensajes de integracion que se utilizan en los microservicios de la solución.

Los mensajes de integración son objetos que se utilizan para enviar y recibir datos entre microservicios. Estos mensajes pueden ser utilizados para enviar eventos o comandos entre microservicios.

Todos los Mensajes de Integración implementan la interfaz `IIntegrationMessage` que define las propiedades `MessageId`, `CorrelationId`, `CreatedAt` y `MessageType`. Estas propiedades son utilizadas para identificar y rastrear los mensajes de integración.
El objeto `IIntegrationMessage` esta definido en el proyecto `Joseco.Communication.External.Contracts` que puede ser obtenido
en [NuGet Gallery](https://www.nuget.org/packages/Joseco.Communication.External.Contracts)
