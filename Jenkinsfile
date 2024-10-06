pipeline {
    agent any

    tools {
        dotnetsdk 'dotnet'
    }

    stages {
        stage('Restore') {
            steps {
                script {
                    sh 'dotnet restore'
                }
            }
        }

        stage('Build') {
            steps {
                script {
                    sh 'dotnet build --no-restore'
                }
            }
        }

        stage('Test') {
            steps {
                script {
                    sh 'dotnet test --no-build'
                }
            }
        }
    }
}
