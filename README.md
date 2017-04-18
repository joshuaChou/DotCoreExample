
# Practice .net core & Docker

This is my practice project, use docker and .net core to understand new devops lifecycle. 

PostgreSQL

To backup:

docker exec -u <your_postgres_user> <postgres_container_name> pg_dump -Fc <database_name_here> > db.dump

To drop db:

docker exec -u <your_postgres_user> <postgres_container_name> psql -c 'DROP DATABSE <your_db_name>'

To restore:

docker exec -u <your_postgres_user> <postgres_container_name> pg_restore -C -d '<your_database_name> < db.dump'

