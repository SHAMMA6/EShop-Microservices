# 🚀 Microservices Architecture with .NET

Welcome to the **Microservices Architecture with .NET** repository! This project implements a scalable, high-performance microservices ecosystem using modern .NET technologies, ensuring modularity, maintainability, and performance.

## 📌 Key Features

- **API Gateway** with YARP Reverse Proxy
- **Event-Driven Communication** with RabbitMQ & MassTransit
- **Minimal APIs** with Vertical Slice Architecture
- **Redis-Powered Caching Service**
- **gRPC-Based High-Performance Microservice**
- **DDD & Clean Architecture Microservice**
- **Shopping Web Client (ASP.NET Razor Pages)**
- **Centralized Building Blocks for Logging, Validation & Exception Handling**

---

## 🏗️ Architecture Overview

### 1️⃣ API Gateway with YARP Reverse Proxy

- Implements **Gateway Routing Pattern** & **Backend-for-Frontend (BFF) Pattern**
- **Rate Limiting** ensures fair resource allocation
- **Centralized Authentication, Authorization & Logging**

### 2️⃣ Event-Driven Communication & Messaging

- Uses **RabbitMQ & MassTransit** for seamless messaging
- Implements **AMQP, Publish/Subscribe, Saga Pattern, and Outbox Pattern**
- Ensures **Reliable & Decoupled** Communication between services

### 3️⃣ Minimal APIs & Vertical Slice Architecture

- Implements **CQRS, MediatR, and Marten Document DB** (PostgreSQL)
- Uses **Carter & Mapster** for high-performance routing and DTO mapping
- **FluentValidation** ensures robust data validation

### 4️⃣ Redis-Powered Caching Service

- Implements **Cache-aside Pattern** for optimized caching
- Uses **Redis Distributed Cache** to store frequently accessed data
- Applies **Decorator & Repository Patterns** for extensibility

### 5️⃣ gRPC-Based High-Performance Microservice

- Uses **gRPC** for fast, efficient inter-service communication
- Built with **SQLite & Entity Framework Core**
- Implements **FluentValidation & Mapster** for DTO transformations

### 6️⃣ DDD & Clean Architecture Microservice

- Implements **Domain-Driven Design (DDD), CQRS, and Event Sourcing**
- Uses **Entity Framework Core & SQL Server**
- Encapsulates business logic with a **Rich Domain Model**
- Utilizes **Interceptors** for cross-cutting concerns

### 7️⃣ Shopping Web Client - ASP.NET Razor Pages

- Uses **Refit-powered HttpClientFactory** for seamless API communication
- Built with **Bootstrap 4 & ASP.NET Core Razor Pages**
- Implements **View Components, Tag Helpers, and Model Bindings**

### 8️⃣ Centralized Building Blocks

- **Logging & Validation Behavior** standardizes error handling
- **Custom Exception Handling** ensures consistent API responses
- **Logical CQRS Implementation** across services

---

## 🔍 Best Practices Implemented

✔️ **Using Records for DTOs** for Immutability & Performance\
✔️ **Global Usings & Dependency Injection (DI)** for Cleaner Code\
✔️ **Following SOLID Principles** for Maintainability\
✔️ **Auto Migrations** for Seamless Database Updates\
✔️ **Health Checks** for Monitoring Service Availability\
✔️ **Feature Flags** for Dynamic Configuration Without Deployment

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Docker](https://www.docker.com/)
- [RabbitMQ](https://www.rabbitmq.com/)
- [Redis](https://redis.io/)
- [PostgreSQL](https://www.postgresql.org/)



