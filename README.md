
<h1 align="center">FinPortfolio (WIP)</h1>
<p align="center">
  <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/Microsoft_.NET_logo.svg/1024px-Microsoft_.NET_logo.svg.png" alt="C#" width="50" height="50"/>
  <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/React-icon.svg/2300px-React-icon.svg.png" alt="React" width="50" height="50"/>
  <img src="https://cdn.worldvectorlogo.com/logos/jwt-3.svg" alt="JWT" width="50" height="50"/>
  <img src="https://mvpcluster.com/wp-content/uploads/2016/04/sql-server-1.png" alt="SQL Server" width="50" height="50"/>
</p>

## Descripción
FinPortfolio es una aplicación que permite a los usuarios gestionar su portafolio financiero de manera eficiente, con la capacidad de agregar stocks y compartir comentarios sobre ellos. Desarrollada en React TypeScript para el frontend y .NET para el backend.

## Funcionalidades Clave
- 🔍 **Búsqueda Financiera Rápida:** Encuentra información relevante de manera eficiente.
- 👤 **Gestión de Usuarios:** Crea una cuenta, inicia sesión y accede a un portafolio personalizado.
- 📈 **Gestión de Stocks:** Agrega y administra stocks en tu portafolio.
- 💬 **Comentarios en Stocks:** Comparte opiniones e información adicional sobre stocks.

## Tecnologías Utilizadas
- Frontend: React TypeScript
- Backend: .NET API con Entity Framework Core
- Base de Datos: SQL Server
- Autenticación: JWT (JSON Web Tokens)

## To-Do List
- [X] 🛠 Desarrollar la API.
- [ ] 🚀 Desarrollar Frontend.

## Instalación
1. **Clonar el Repositorio:** `git clone https://github.com/tu-usuario/FinPortfolio.git`
2. **Backend:** Navega al directorio del backend: `cd FinPortfolio/api` -> Configura el archivo de configuración -> `dotnet run`
3. **Frontend:** (WIP) Navega al directorio del frontend: `cd ../frontend` -> `npm install` -> `npm start`

## Configuración
### FMP Service
Para agregar los datos de los stocks automáticamente, necesitas obtener una API KEY en [FMP](https://site.financialmodelingprep.com/) y agregarla al archivo `./api/appsettings.json` en la entrada "FMPKey".

### Puerto API
Puedes cambiar el puerto en el que se ejecuta la API cambiando la entrada "APIPort" del archivo anteriormente mencionado.

## Documentacion
Puedes revisar la documentación en `http://localhost:5000/swagger/index.html` una vez hayas lanzado la API

## Uso
1. **Gestión de Usuarios:**
    - Crea una cuenta de usuario.
    - Inicia sesión para acceder a tu portafolio personalizado.
  
2. **Gestión de Stocks:**
    - Busca stocks de interés.
    - Agrega stocks a tu portafolio.

3. **Comentarios en Stocks:**
    - Deja comentarios en los stocks para compartir tus opiniones e información adicional.

## Desarrollo
### Diagrama de la Base de Datos
![UML](https://raw.githubusercontent.com/juzt3/FinPortfolio/main/FinPortfolio.drawio.svg)

## Contacto
LinkedIn: [Felipe Gatica Cea](https://www.linkedin.com/in/felipe-gatica-cea-124b01270/)

---
