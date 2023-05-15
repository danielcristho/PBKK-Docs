# Laravel Landing

Create database using Docker.

```bash
docker run -d \
  --name mysql \
  --restart unless-stopped \
  -e MYSQL_DATABASE=landing-db \
  -e MYSQL_ROOT_PASSWORD=secret \
  -e MYSQL_PASSWORD=dev_password \
  -e MYSQL_USER=landing-user \
  mysql:8

```

Then change .env file.