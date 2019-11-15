public class ReadyForPrint implements IState {
    @Override
    public void print(MachineForPrinting context) {
        System.out.println("Печатаем...");
        //уменьшаем деньги на сумму печати
        context.setState(new CloseState());
    }

    @Override
    public void selectDoc(MachineForPrinting context, String doc) {
        //ничего не делаем
    }

    @Override
    public void selectDevice(MachineForPrinting context, String device) {
        //ничего не делаем
    }

    @Override
    public void toPay(MachineForPrinting context, int money) {
        //не принимаем деньги
    }

    @Override
    public Integer getChange(MachineForPrinting context) {
        return null;
    }
}
