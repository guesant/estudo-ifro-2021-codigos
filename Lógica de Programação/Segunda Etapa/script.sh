#!/usr/bin/env bash

executar_projeto () {
  clear
  echo Próximo Projeto: $1
  code $1/Program.cs
  dotnet run --project $1
  echo Execução terminada. Aperte Enter para executar o próximo projeto.
  read
}

criar_projeto () {
  local folder="$1"
  dotnet new console -o $folder &
}

criar_projetos_sequencia() {
  local prefixo="$1"
  local inicio="$2"
  local fim="$3"

  for (( n = $inicio; n <= $fim; n++ )); do
    local folder=${prefixo}${n}
    criar_projeto $folder
  done
}

criar_projetos_lista() {
  local args="$@"
  local prefixo="$1"
  local items=("${args[@]:1}")

  for i in "${items[@]}"; do
    local folder=${prefixo}${i}
    criar_projeto $folder
  done
}

executar_projetos_sequencia() {
  local prefixo="$1"
  local inicio="$2"
  local fim="$3"

  for (( n = $inicio; n <= $fim; n++ )); do
    local folder=${prefixo}${n}
    executar_projeto $folder
  done
}

executar_projetos_lista() {
  local args=("$@")
  local prefixo="$1"
  local items=("${args[@]:1}")

  for i in "${items[@]}"; do
    local folder=${prefixo}${i}
    echo $folder
    executar_projeto $folder
  done
}


Cap6Items=("18" "20" "22" "24" "26" "28")
Cap7Items=("14" "16" "18" "20")

# executar_projetos_lista Cap6_Exercicio "${Cap6Items[@]}"
# executar_projetos_lista Cap7_Exercicio "${Cap7Items[@]}"
# executar_projetos_sequencia Prova_Cap4_Exercicio 1 10

# criar_projetos_lista Cap7_Exercicio $Cap7Items
# criar_projetos_sequencia Prova_Cap4_Exercicio 1 10
# executar_projetos Aula_6 1 7


zip_projects() {
  find . | awk '! /obj|bin/' | xargs zip $1.zip
}
