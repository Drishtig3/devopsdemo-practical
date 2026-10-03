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
                bat '"C:\\Users\\chand\\AppData\\Local\\Programs\\DockerDesktop\\resources\\bin\\docker.exe" build -t devops-demo:latest .'
            }
        }

        stage('Deploy') {
            steps {
                bat '''
                "C:\\Users\\chand\\AppData\\Local\\Programs\\DockerDesktop\\resources\\bin\\docker.exe" rm -f devops-demo-container 2>NUL
                "C:\\Users\\chand\\AppData\\Local\\Programs\\DockerDesktop\\resources\\bin\\docker.exe" run -d --name devops-demo-container -p 8080:8080 devops-demo:latest
                '''
            }
        }
    }
}