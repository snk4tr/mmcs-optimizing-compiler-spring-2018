### Название задачи
Модифицировать итерационный Алгоритм с нумерацией базовых блоков и подсчётом количества итераций.

#### Постановка задачи
Модифицировать итерационный Алгоритм с нумерацией базовых блоков и подсчётом количества итераций.

#### Зависимости задач в графе задач
Задача зависит от:
* Обобщенный итерационный алгоритм
От задачи зависит:
* Тестирование 

#### Теоретическая часть задачи
При использовании порядка "вглубь" количество проходов, необходимое для распространения любого достигающего определения вдоль люого ацикличного пути, не более чем на единицу превышает число ребер пути, идущих от блока с большим номером к блоку с меньшим. Эти ребра являются отступающими, так что необходимое количество проходов на единицу больше глубины. Предыдущему алгоритму для того, чтобы определить достижение всех определений, требуется один дополнительный проход, так что верхняя граница количества проходов, необходимых алгоритму с упорядочиванием блоков вглубь, в действительности на 2 превышает глубину. Изучение показало, что средняя глубина типичного графа потока равна 2.75. Таким образом, алгоритм сходится очень быстро. 

#### Практическая часть задачи (реализация)
```csharp
public class OptimizedGenericIterativeAlgorithm<T> : IAlgorithm<T>
    {
        public Func<T, T, bool> Comparer { get; set; }
        public Func<(T, T)> Fill { get; set; }
        public Func<(T, T), (T, T), bool> Finish { get; set; }

        // Нумерация графа (для оптимизации передается в порядке обратного обхода)
        public IGraphNumerator Numerator { get; set; }

        // Счётчик операций
        public int OpsCount { get; set; }

        public InOutData<T> Analyze(
            ControlFlowGraph graph,
            ILatticeOperations<T> ops,
            ITransferFunction<T> f)
        {
            var data = new InOutData<T>
            {
                [graph.CFGNodes.ElementAt(0)] = Fill()
            };

            foreach (var node in graph.CFGNodes)
                data[node] = Fill();
            OpsCount = 0;
            var outChanged = true;
            while (outChanged)
            {
                outChanged = false;
                foreach (var block in graph.CFGNodes.OrderBy(x => Numerator.GetIndex(x))) // упорядочивание базовых блоков
                {
                    OpsCount++; // увеличение счетчика операций
                    var inset = block.Parents.Aggregate(ops.Lower, (x, y)
                        => ops.Operator(x, data[y].Item2));
                    var outset = f.Transfer(block, inset, ops);

                    if (!Finish((inset, outset), data[block]))
                    {
                        outChanged = true;
                    }
                    data[block] = (inset, outset);
                }
            }
            return data;
        }
    }
```

#### Тесты
Тестирование проводилось в другом задании.



