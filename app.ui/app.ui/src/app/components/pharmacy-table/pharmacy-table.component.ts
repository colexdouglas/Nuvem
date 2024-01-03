import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { GridModule } from '@progress/kendo-angular-grid';
import { Pharmacy } from 'src/app/model/pharmacy-model';
import { PharmacyService } from 'src/app/service/pharmacy-service.service';

@Component({
  selector: 'app-pharmacy-table',
  templateUrl: './pharmacy-table.component.html',
  styleUrls: ['./pharmacy-table.component.css']
})
export class PharmacyTableComponent implements OnInit {
    
    public pharmacy: Pharmacy[] = [];

    public formGroup: FormGroup = this.formBuilder.group({
      pharmacyId: null,
      name: '',
      address: '',
      city: '',
      state: '',
      zip: null,
      prescriptionsFilled:  null,
      updatedDate:  null,
    });

    ngOnInit() {
      this.pharmacyService.getPharmacyApi().subscribe(res => {
        this.pharmacy = res;
      });
    }

    constructor(public pharmacyService: PharmacyService,
                private formBuilder: FormBuilder) {
                  this.createFormGroup = this.createFormGroup.bind(this);
                }

    getPharmacys() {
      return this.pharmacyService.getPharmacyApi();
    }

    public createFormGroup = (args: any): FormGroup => {
      const item = args.isNew ? new Pharmacy() : args.dataItem;
  
      this.formGroup = this.formBuilder.group({
          pharmacyId: item.pharmacyId,
          name: item.name ,
          address: item.address,
          city: item.city,
          state: item.state,
          zip: item.zip,
          prescriptionsFilled: item.prescriptionsFilled,
          updatedDate: item.updatedDate,
      });
  
      return this.formGroup;
  }

  public updatePharmacy(updatedPharmacy: Pharmacy){
    return this.pharmacyService.updatePharmacy(updatedPharmacy).subscribe(
      (response) => {
        console.log('Data updated successfully', response);
      })
    }

}
