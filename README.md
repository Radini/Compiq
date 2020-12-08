# Compiq
Helpware


Para poder ejecutar el proyecto habra que relaiza rlos siguientes pasos

 - El .sln principal que esta contenido en MoneyExchange.API 
 - Asegurarse de que en las properties del mismo este validado que ambos proyectos se ejecuten simultaneamente. 
 - También en el appsetings.json habría que cambiar el connectin string por el de su computadora, por su LocalDB
 - En el App.Config hay que actualizar ApiBaseAddress que vendría siendo la address base del API (tu localhost mas el puerto seleccionado)
 - En el App.Config hay que actualizar ApiGetAddress que vendría siendo la address base del API (tu localhost mas el puerto seleccionado) mas el nombre del endpoint
 - En el App.Config hay que actualizar el ExecutionFrequency en caso de querer que el cliente lea con diferente frecuencia del WS TipoCambio
