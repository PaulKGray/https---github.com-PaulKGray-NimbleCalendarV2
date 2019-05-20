import * as React from 'react';
import { FormComponentProps } from 'antd/lib/form'; 
import AppComponentBase from 'src/components/AppComponentBase';
import StaffStore from 'src/stores/staffStore';
import Stores from 'src/stores/storeIdentifier';
import { inject } from 'mobx-react';

export interface IStaffProps extends FormComponentProps {
    staffStore: StaffStore;
}

export interface IStaffState {
}

@inject(Stores.StaffStore)
class Staff extends AppComponentBase<IStaffProps, IStaffState> {
    formRef: any;

    state = {
    }


    return (){
       <p>Thank fuck</p>
    }
}

export default Staff;