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
                sh 'dotnet restore'
                sh 'dotnet build --configuration Release'
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test --configuration Release'
            }
        }

        stage('Docker Build') {
            steps {
                sh 'docker build -t devops-demo:latest .'
            }
        }

        stage('Deploy') {
            steps {
                sh 'docker rm -f devops-demo-container || true'
                sh 'docker run -d -p 8080:8080 --name devops-demo-container devops-demo:latest'
            }
        }
    }
}
