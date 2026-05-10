# CalculadoraDeMedias04

> Aplicativo Desktop — Engenharia de Software Ágil Aplicada | Atividade II | Equipe 04

---

## 📋 Sobre o Projeto

Aplicativo **Desktop Windows** desenvolvido em **C# / WinForms** para cálculo de médias semestrais e finais de alunos de instituições de ensino superior (IES) e médio/técnico (IEMT).

O sistema realiza:
- cálculo automático de médias;
- validação de entradas numéricas;
- arredondamento padronizado;
- definição automática do status do aluno.

Projeto desenvolvido para a disciplina de **Engenharia de Software Ágil Aplicada (ESWA)** em conjunto com **POO-C#**, ministradas pelo Prof. Marcos M. Chaves.

---

## 🖥️ Interface do Sistema

O aplicativo possui uma interface simples e intuitiva dividida em duas etapas principais.

### 📌 Status do Aluno

Exibe automaticamente o resultado acadêmico do aluno:

- 🟡 Em Andamento
- 🟢 Aprovado
- 🟠 Em Exame
- 🔴 Reprovado

---

### 📚 Seção Semestral

Campos disponíveis:
- NP1
- NP2
- PIM

Resultado:
- Média Semestral (MS)

Ações:
- Limpar
- Calcular Semestral

---

### 📝 Seção Final

Disponível apenas quando o aluno estiver em exame.

Campos disponíveis:
- Exame

Resultado:
- Média Final (MF)

Ações:
- Limpar
- Calcular Final

---

## 📐 Regras de Negócio

### Média Semestral (MS)

```math
MS = (4 × NP1 + 4 × NP2 + 2 × PIM) / 10
```

### Critérios

- MS ≥ 7,0 → Aprovado
- MS < 7,0 → Em Exame

---

### Média Final (MF)

```math
MF = (MS + Exame) / 2
```

### Critérios

- MF ≥ 5,0 → Aprovado
- MF < 5,0 → Reprovado

---

## 🔄 Arredondamento

O sistema utiliza arredondamento padronizado:

```csharp
Math.Round(media, 1, MidpointRounding.AwayFromZero)
```

---

## ⚙️ Como Executar

### ✅ Pré-requisitos

- Windows 10 ou superior
- .NET 10 Runtime
- Visual Studio 2022 (opcional)

---

### ▶️ Executando pelo Visual Studio

1. Clone este repositório

```bash
git clone https://github.com/m4rcosJr/ESWA04CalculadoraDeMedias.git
```

2. Abra o arquivo:

```txt
CalculadoraDeMedias04.slnx
```

3. Defina o projeto principal como inicialização

4. Execute pressionando:

```txt
F5
```

---

### 📦 Executando pelo executável

1. Acesse a pasta:

```txt
bin/Release
```

2. Execute:

```txt
CalculadoraDeMedias04.exe
```

---

## 🔗 Biblioteca Utilizada

Este projeto utiliza a biblioteca:

### ESWA04CalculadoraDeMedias

Responsável por:
- cálculos;
- validações;
- sanitização;
- regras de negócio.

Instalação via NuGet:

```bash
dotnet add package ESWA04CalculadoraDeMedias
```

---

## 🏗️ Estrutura do Projeto

```txt
CalculadoraDeMedias04/
├── FormMain.cs
├── FormMain.Designer.cs
├── Program.cs
└── README.md
```

---

## 🛠️ Tecnologias Utilizadas

- C#
- .NET 10
- Windows Forms (WinForms)
- Programação Orientada a Objetos (POO)
- Princípios SOLID

---

## 👥 Equipe 04

| Aluno | RA |
|---|---|
| Marcos Ferreira dos Saantos Junior | F3616F2 |
| Cauã Santos Aguirre | R6826B0 |
| Eduardo Matheus Barboza de Medeiros | H659558 |

---

## 📚 Disciplinas

- Engenharia de Software Ágil Aplicada
- Programação Orientada a Objetos — C#

---

## 👨‍🏫 Docente

**Prof. Marcos M. Chaves**

---

## 📄 Licença

Projeto desenvolvido para fins acadêmicos.
