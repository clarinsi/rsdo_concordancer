docker build --no-cache -t rsdo-concordancer-api -f src/apps/Rsdo.Concordancer.Api/Dockerfile .
docker build --no-cache --build-arg WEBAPP_PUBLIC_URL=/korpus -t rsdo-concordancer-api-term-portal -f src/apps/Rsdo.Concordancer.Api/Dockerfile .
docker build --no-cache -t rsdo-concordancer-systemmanager -f src/apps/Rsdo.Concordancer.SystemManager/Dockerfile .

docker login ghcr.io

docker tag rsdo-concordancer-api ghcr.io/clarinsi/rsdo-concordancer-api:latest
docker tag rsdo-concordancer-api ghcr.io/clarinsi/rsdo-concordancer-api:v1.0.4
docker tag rsdo-concordancer-api ghcr.io/clarinsi/rsdo-concordancer-api:v1.0
docker tag rsdo-concordancer-api ghcr.io/clarinsi/rsdo-concordancer-api:v1

docker tag rsdo-concordancer-api-term-portal ghcr.io/clarinsi/rsdo-concordancer-api-term-portal:latest
docker tag rsdo-concordancer-api-term-portal ghcr.io/clarinsi/rsdo-concordancer-api-term-portal:v1.0.4
docker tag rsdo-concordancer-api-term-portal ghcr.io/clarinsi/rsdo-concordancer-api-term-portal:v1.0
docker tag rsdo-concordancer-api-term-portal ghcr.io/clarinsi/rsdo-concordancer-api-term-portal:v1

docker tag rsdo-concordancer-systemmanager ghcr.io/clarinsi/rsdo-concordancer-systemmanager:latest
docker tag rsdo-concordancer-systemmanager ghcr.io/clarinsi/rsdo-concordancer-systemmanager:v1.0.4
docker tag rsdo-concordancer-systemmanager ghcr.io/clarinsi/rsdo-concordancer-systemmanager:v1.0
docker tag rsdo-concordancer-systemmanager ghcr.io/clarinsi/rsdo-concordancer-systemmanager:v1

docker push --all-tags ghcr.io/clarinsi/rsdo-concordancer-api
docker push --all-tags ghcr.io/clarinsi/rsdo-concordancer-api-term-portal
docker push --all-tags ghcr.io/clarinsi/rsdo-concordancer-systemmanager
