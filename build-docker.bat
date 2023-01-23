docker build --no-cache -t rsdo-concordancer-api -f src/apps/Rsdo.Concordancer.Api/Dockerfile .
docker build --no-cache --build-arg WEBAPP_PUBLIC_URL=/korpus -t rsdo-concordancer-api-term-portal -f src/apps/Rsdo.Concordancer.Api/Dockerfile .
docker build --no-cache -t rsdo-concordancer-systemmanager -f src/apps/Rsdo.Concordancer.SystemManager/Dockerfile .
