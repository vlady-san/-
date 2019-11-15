public class InitState implements IState {

    private String warning="Выберете устройство";

    @Override
    public void print(MachineForPrinting context) {
        System.out.println(warning);
    }

    @Override
    public void selectDoc(MachineForPrinting context, String doc) {
        System.out.println(warning);
    }

    @Override
    public void selectDevice(MachineForPrinting context,String device) {
        System.out.println("Вы выбрали устройство: "+device);
        context.setDevice(device);
        context.setState(new ReadyForSelDoc());

    }

    @Override
    public void toPay(MachineForPrinting context, int money) {
        System.out.println(warning);
    }

    @Override
    public Integer getChange(MachineForPrinting context) {
        return null;
    }

}
