Here you go, Sanali! 🎉 This is your **final polished README**, ready to copy-paste into your GitHub repo. It includes everything we discussed: table of contents, clean documentation reference, optional badge, and a professional tone.

---

```markdown
# 🎮 GameStore Web App – Azure Deployment

![Deployment Status](https://img.shields.io/badge/Deployed-Azure-brightgreen)
![Grade Level](https://img.shields.io/badge/Assignment-Grade%3A_VG-blue)

This repository contains a cloned version of the `cua24s_gamestore` application provided by our teacher as part of the *Inlämningsuppgift G* for the MTA course at JENSEN Yrkeshögskola. The main task was to focus on deploying the app to **Azure App Service** and configuring related **cloud services**.

---

## 📚 Table of Contents
- [Assignment Scope](#-assignment-scope)
- [Live App](#-live-app)
- [Tools & Services Used](#-tools--services-used)
- [VG-Level Features](#-vg-level-features-väl-godkänd)
- [Deployment Challenges & Solutions](#-deployment-challenges--solutions)
- [Project Documentation](#-project-documentation)
- [Author](#-author)
- [Assignment Status](#-assignment-status)

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

## 🌟 VG-Level Features (Väl Godkänd)

The following advanced features were implemented to fulfill the requirements for a **VG (Väl Godkänd)** grade:

### 🚀 Automatic Scaling – Azure App Service
- Upgraded from B1 to **Standard (S1)** plan to unlock autoscaling.
- Configured scaling rules:  
  - **Scale out**: if CPU > 70% for 5 minutes.  
  - **Scale in**: if CPU < 30% for 5 minutes.
- Verified scaling behavior via **Metrics** in Azure Portal.

### 🗂 Azure Storage Account for Static Files
- Created storage account `sanaligamestorage` in the same region as the app.
- Enabled **blob anonymous access** for static file sharing.
- Created container `images` and uploaded an app screenshot.
- Static file now accessible at:  
  [📷 App Screenshot](https://sanaligamestorage.blob.core.windows.net/images/BrowserShowingLiveApp.png)

### 🔐 Azure Key Vault for Secret Management
- Created Key Vault: `sanaligamestore-keyvault`.
- Stored secret `MyAPIKey` securely.
- Enabled **System-assigned identity** on App Service and assigned the role `Key Vault Secrets User`.
- Connected Key Vault to app using:
  ```csharp
  builder.Configuration.AddAzureKeyVault(
      new Uri("https://sanaligamestore-keyvault.vault.azure.net/"),
      new DefaultAzureCredential());
  ```

### 🔄 CI/CD Pipeline with GitHub Actions
- Could not use **Azure DevOps** due to school account restrictions.
- Switched to **GitHub Actions** via Azure Deployment Center.
- Secrets added in GitHub repo for authentication.
- Deployment tested by pushing code, triggering successful deployment pipeline.
- Solved Git origin error using:
  ```bash
  git remote set-url origin https://github.com/RMSSanali/cua24s_gamestore.git
  git pull origin main --rebase
  git push origin main
  ```

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

