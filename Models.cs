using System;

namespace ChaipiaInventoryProgram
{
    public class Item
        {
                public string Name { get; set; } = "";
                        public int Quantity { get; set; }
                                public decimal CurrentPrice { get; set; }
                                        public string Remarks { get; set; } = "";
                                            }

                                                public class HistoryRecord
                                                    {
                                                            public DateTime Date { get; set; }
                                                                    public string Category { get; set; } = "";
                                                                            public string Name { get; set; } = "";
                                                                                    public int StockIn { get; set; }
                                                                                            public int StockOut { get; set; }
                                                                                                    public decimal UnitPrice { get; set; }
                                                                                                            public int QuantityAfter { get; set; }
                                                                                                                    public string Remarks { get; set; } = "";
                                                                                                                            public decimal LineAmount => (StockIn - StockOut) * UnitPrice;
                                                                                                                                }
                                                                                                                                }