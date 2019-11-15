public interface IState {
    void print(MachineForPrinting context);
    void selectDoc(MachineForPrinting context, String doc);
    void selectDevice(MachineForPrinting context,String device);
    void toPay(MachineForPrinting context, int money);
    Integer getChange(MachineForPrinting context);
}
