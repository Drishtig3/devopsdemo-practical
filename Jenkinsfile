pipeline {
    agent any

    stages {

        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet restore'
                bat 'dotnet build --configuration Release'
            }
        }

        stage('Test') {
            steps {
                bat 'dotnet test --configuration Release'
            }
        }

        stage('Docker Build') {
            steps {
                bat 'docker build -t devops-demo:latest .'
            }
        }

        stage('Deploy') {
            steps {
                bat 'docker rm -f devops-demo-container || true'
                bat 'docker run -d -p 8080:8080 --name devops-demo-container devops-demo:latest'
            }
        }
    }
}
