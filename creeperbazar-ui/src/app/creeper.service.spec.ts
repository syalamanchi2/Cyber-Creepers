import { TestBed } from "@angular/core/testing";
import { CreeperService } from "./creeper.service"

fdescribe('creeperservice', () => {
    let service: CreeperService;
    beforeEach(()=> {
        TestBed.configureTestingModule({});
        service=TestBed.inject(CreeperService)
    });
    it('should be created', () => {
        expect(service).toBeTruthy
    })
}