```markdown
# 🎮 GameStore Web App – Azure Deployment

![Deployment Status](https://img.shields.io/badge/Deployed-Azure-brightgreen)
![Grade Level](https://img.shields.io/badge/Assignment-Grade%3A_VG-blue)

This repository contains a cloned version of the `cua24s_gamestore` application provided by our teacher as part of the *Inlämningsuppgift G* for the
MTA course at JENSEN Yrkeshögskola. The main task was to focus on deploying the app to **Azure App Service** and configuring related **cloud services**.

---

## 📚 Table of Contents
- [Extended Description](#-extended-description)
- [Assignment Scope](#-assignment-scope)
- [Live App](#-live-app)
- [Tools & Services Used](#-tools--services-used)
- [VG-Level Enhancements](#-vg-level-enhancements)
- [Deployment Challenges & Solutions](#-deployment-challenges--solutions)
- [Project Documentation](#-project-documentation)
- [Author](#-author)
- [Assignment Status](#-assignment-status)

---

## 📖 Extended Description

This project was carried out as part of the *Inlämningsuppgift G-nivå* for the course **MTA** at **JENSEN Yrkeshögskola**. The purpose of the assignment was to gain hands-on experience with deploying a pre-built web application to the cloud using **Microsoft Azure**.

The web application itself, `cua24s_gamestore`, was provided by our teacher through a public GitHub repository. My responsibility was focused entirely on the **cloud-based aspects**, not the application development.

Key tasks performed in this project:

- ✅ **Cloned** the given project repository locally  
- ✅ Tested the application locally using **Visual Studio Code**  
- ✅ Created an **Azure App Service** to host the web application  
- ✅ Deployed the application via **VS Code Azure extension**  
- ✅ Enabled **Application Insights** for logging and basic monitoring  
- ✅ Verified performance data, live metrics, and request tracking  
- ✅ Configured **IAM (Identity and Access Management)** by assigning roles  
- ✅ Activated **SSL (HTTPS Only)** to secure the application  

All steps and configurations were carefully documented through screenshots and written explanations, as required by the assignment instructions.

The result is a fully functional and secure web application running on Azure, monitored through Application Insights and managed using Azure’s built-in access control system.

---

## 📌 Assignment Scope

This project **does not include development of the web app itself**.  
The primary focus was on **cloud deployment and configuration** tasks including:

- Creating an App Service on Azure  
- Deploying the app using **Visual Studio Code**  
- Enabling **Application Insights**  
- Implementing basic **security settings** (IAM and SSL)  
- Documenting the deployment process

---

## 🔗 Live App

Visit the deployed site here:  
[🌐 GameStore Live App](https://sanali-gamestore-fscgfmhjc3g3efe2.swedencentral-01.azurewebsites.net)

---

## 🛠 Tools & Services Used

- Azure App Service  
- Visual Studio Code  
- GitHub (for code repository)  
- GitHub Actions (CI/CD)  
- Application Insights  
- Azure Storage Account  
- Azure Key Vault  
- Access Control (IAM)  
- TLS/SSL settings

---

## 🆙 VG-Level Enhancements

This project was later extended to meet the **Väl Godkänd (VG)** level of the assignment. These advanced features were implemented in addition to the
original G-level tasks:

- 🚀 **Automatic Scaling**  
  - Configured CPU-based autoscaling rules on Azure App Service Plan (Standard S1)

- 🗂 **Azure Storage Account**  
  - Used for storing static files like screenshots  
  - Enabled blob-level anonymous access via secure container setup

- 🔐 **Azure Key Vault**  
  - Stored sensitive secrets securely  
  - Enabled system-assigned identity & configured access via role-based IAM

- 🔄 **CI/CD with GitHub Actions**  
  - Replaced Azure DevOps due to access limitations  
  - Configured automated deployment workflow through GitHub Actions

---

## 🧩 Deployment Challenges & Solutions

### ⚠️ GitHub Push Error (403 Forbidden)
- **Issue:** Could not push code to GitHub due to permission errors.  
- **Solution:** Updated remote origin to my own repo and successfully pushed.

### 🚫 Azure DevOps Access Denied
- **Issue:** My school account blocked Azure DevOps organization creation.  
- **Solution:** Used GitHub Actions instead for CI/CD pipeline.

### 🧪 Application Insights Metrics Not Showing
- **Issue:** `CPU Percentage` was not initially available in Metrics.  
- **Solution:** Switched to `CPU Time (Sum)` as an alternative to verify logging.

---

## 📄 Project Documentation

🗂 **Screenshots and full technical documentation** are included in the accompanying **presentation/report (PDF or PowerPoint)** as part of this submission.  
This includes all Azure configuration steps for:

- Application Insights  
- Scaling  
- Key Vault access  
- IAM roles  
- Storage account setup  
- GitHub Actions workflow  

---

## 👤 Author

**Sanali Sewwandi**  
Cloud Developer Student – CUA24S  
JENSEN Yrkeshögskola, 2025

---

## 📄 Assignment Status

✅ All tasks required for **Godkänd (G)** and **Väl Godkänd (VG)** grades are successfully completed as per the [assignment instructions](https://github.com/Degendeg/cua24s_gamestore).
```
