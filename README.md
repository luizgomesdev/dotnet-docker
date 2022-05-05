# OpenTelemetry - Grafana

This demo application demonstrates how to monitor a JavaScript application using open source observability software. The following projects are used:

- [OpenTelemetry](https://opentelemetry.io/) - Instrument the application and send observability data to each backend.
- [Jaeger](https://www.jaegertracing.io/) - Distributed tracing backend.
- [Prometheus](https://prometheus.io/) - Metrics and alerting backend.
- [Loki](https://grafana.com/oss/loki/) - Logs aggregation system.
- [Grafana](https://grafana.com/) - Visualize all of our observability data.

## Project Structure
![App architecture](./docs/assets/app_architecture.png)
- api/ - C# MVC. Instrumented with OpenTelemetry
- db/  - Stores copy of Postgres data for persistence.
- config/ - Standard configuration for Prometheus, Promtail, Loki, etc.
- data/ - Stores server logs

## Additional Resources
- [Grafana Demo](https://play.grafana.org/d/000000012/grafana-play-home?orgId=1)
- [Grafana Cloud](https://grafana.com/products/cloud/) - Actually useful free tier
- [OpenTelemetry Key Terms](https://github.com/open-telemetry/opentelemetry-specification/blob/main/specification/overview.md)
- [OpenTelemetry JS](https://github.com/open-telemetry/opentelemetry-js)
- [OpenTelemetry JS Contrib](https://github.com/open-telemetry/opentelemetry-js-contrib)
- [OpenTelemetry Status](https://opentelemetry.io/status/)