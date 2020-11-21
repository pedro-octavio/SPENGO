export default class UpdateWalletRequestModel {
    constructor(id: string, name: string, startDate: Date, endDate: Date) {
        this.id = id
        this.name = name
        this.startDate = startDate
        this.endDate = endDate
    }

    id: string
    name: string
    startDate: Date
    endDate: Date
}
