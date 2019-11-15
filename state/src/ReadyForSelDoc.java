public class ReadyForSelDoc implements IState {
    private String warning="Выберете документ";
    @Override
    public void print(MachineForPrinting context) {
        System.out.println(warning);
    }

    @Override
    public void selectDoc(MachineForPrinting context, String doc) {
        System.out.println("Вы выбрали документ: "+doc);
        context.setDocument(doc);
        context.setState(new ReadyForPay());
    }

    @Override
    public void selectDevice(MachineForPrinting context, String device) {
        System.out.println("Вы изменили устройство на: "+device);
        context.setDevice(device);
        context.setState(this);
    }

    @Override
    public void toPay(MachineForPrinting context, int money) {
        System.out.println(warning);
        // у меня такой автомат, в котором можно платить после подсчета того, сколько нужно заплатить,
        // то есть после выбора документа
    }

    @Override
    public Integer getChange(MachineForPrinting context) {
        return null;
    }
}
