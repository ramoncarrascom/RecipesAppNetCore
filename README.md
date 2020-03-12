# RecipesAppNetCore
Sample Recipes App application using .NET Core 3.1

## Database

### Database setup
MariaDb / MySQL database. Must create a new database (ie recipes_net) and a user (ie recipesuser). To avoid problems, grant all privileges to user (only for testing/development environments!!).

### Database initialization
Once DbContext connection string is configured, open the Package Manager Console and run:

- add-migration DB_Init -Context RecipesContext
- update-database DB_Init -Context RecipesContext
