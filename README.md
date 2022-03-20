# 🐱‍💻 Project POO CSharp

Projeto de estudos sobre POO e outros conceitos com base em resumos e estudos.

## Implementações Importantes

### Guid

Neste projeto foi criado uma classe abstrata para repassar as informações necessárias para elas.

A classe _Content_ conta com um construtor que irá gerar um Guid para todas as outras classes, de forma que não se tenha a necessidade de criar outros Id's para cada classe criada.

Código da Implementação:

```c#
    public Content()
    {
      // Construtor para não criar outros Id's
      Id = Guid.NewGuid();
    }
```

Em desenvolvimento...
