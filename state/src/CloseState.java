public class CloseState implements IState {
    @Override
    public void print(MachineForPrinting context) {
        System.out.println("Выберете устройство");
    }

    @Override
    public void selectDoc(MachineForPrinting context, String doc) {
        context.setState(new ReadyForSelDoc());
    }

    @Override
    public void selectDevice(MachineForPrinting context, String device) {
        context.setState(new InitState());
    }

    @Override
    public void toPay(MachineForPrinting context, int money) {

    }

    @Override
    public Integer getChange(MachineForPrinting context) {
        return context.getMoney();
    }
}
