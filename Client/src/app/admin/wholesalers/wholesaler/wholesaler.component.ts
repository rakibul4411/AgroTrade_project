import { Component, OnInit } from '@angular/core';
import { WholesalerService } from 'src/app/shared/wholesaler.service';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';


@Component({
  selector: 'app-wholesaler',
  templateUrl: './wholesaler.component.html',
  styleUrls: ['./wholesaler.component.css']
})
export class WholesalerComponent implements OnInit {

  constructor(private service: WholesalerService,
    private toastr: ToastrService){ }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.resetForm();
    this.service.formData = {
      Whole_Saler_ID: null,
      Whole_Saler_Name: '',
      Whole_Saler_Buying_Cost: null,
      Whole_Saler_Transportation_Cost: null,
      Whole_Saler_Storing_Cost: null,
      Whole_Saler_Total_Cost: null,
      Whole_Saler_Selling_Price: null
    }
  }
  onSubmit(form: NgForm) {
    if (form.value.Whole_Saler_ID == null)
      this.insertRecord(form);
   else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postWholeSalers(form.value).subscribe(res => {
      
      this.toastr.success('Inserted successfully', 'ws. Register');
      this.resetForm(form);
      this.service.refreshList();
      
    });
  }

  updateRecord(form: NgForm) {
    this.service.putWholeSalers(form.value).subscribe(res => {
      this.toastr.info('Updated successfully', 'ws. Register');
      this.resetForm(form);
      this.service.refreshList();
    }); 
  }
}
