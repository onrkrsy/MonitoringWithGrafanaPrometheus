# .NET Core Uygulaması için Prometheus ve Grafana ile Monitoring

Bu proje, .NET Core 8 uygulamalarında Prometheus ve Grafana kullanarak izleme işleminin nasıl yapılacağını göstermektedir. 
## Proje Yapısı

- **docker-compose.yml:** Prometheus ve Grafana'yı çalıştırmak için gerekli Docker Compose yapılandırması.
- **prometheus.yml:** Prometheus konfigürasyon dosyası, metriklerin toplandığı hedefler burada tanımlanır.
- **ECommerceAPI/:** .NET Core 8 ile oluşturulmuş basit bir e-ticaret API'si, Prometheus metrikleri entegre edilmiştir.

## Kurulum

Bu projeyi kendi makinenizde çalıştırmak için aşağıdaki adımları takip edebilirsiniz:

1. **Depoyu klonlayın:**

   ```bash
   git clone https://github.com/onrkrsy/MonitoringWithGrafanaPrometheus.git
   cd MonitoringWithGrafanaPrometheus
   ```

2. **Docker Compose ile servisleri başlatın:**

   ```bash
   docker-compose up -d
   ```

3. **Prometheus ve Grafana'ya erişin:**

   - Prometheus: [http://localhost:9090](http://localhost:9090/)
   - Grafana: [http://localhost:3000](http://localhost:3000/)

## Daha Fazla Bilgi

Bu projeyle ilgili detaylı açıklamalar, adım adım kurulum rehberi ve kod parçacıkları için [Medium makalesini](https://medium.com/@onurkarasoy/net-core-uygulaman%C4%B1z%C4%B1-prometheus-ve-grafana-ile-i%CC%87zleme-79ee2d18b04e) inceleyebilirsiniz. Makalede, Prometheus metrik türleri, Grafana'da dashboard oluşturma ve özelleştirme gibi konular ele alınmıştır.


