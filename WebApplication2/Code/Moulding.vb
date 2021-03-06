Namespace RWF
    MustInherit Class Heat
#Region " Fields"
        Private lNumber As Long
        Private dateTapTime As DateTime
        Private sFurnace As String
#End Region
#Region " Property"
        Property Number() As Long
            Get
                Return lNumber
            End Get
            Set(ByVal Value As Long)
                lNumber = Value
            End Set
        End Property
        Property TapTime() As DateTime
            Get
                Return dateTapTime
            End Get
            Set(ByVal Value As DateTime)
                dateTapTime = Value
            End Set
        End Property
        Property Furnace() As String
            Get
                Return sFurnace
            End Get
            Set(ByVal Value As String)
                sFurnace = Value
            End Set
        End Property
#End Region
#Region " Methods"
        Private Sub iniVals()
            lNumber = 0
            dateTapTime = "1900-01-01"
            sFurnace = ""
        End Sub
#End Region
    End Class
    MustInherit Class Wheel
#Region " Fields"
        Private lWheel, lHeat As Long
        Private intPourOrder, intCopeLife, intDragLife, intIngLife, INTCHOTMP, INTDHOTMP, INTSDTMP, INTBCTMP, INTSCTMP, INTLIM As Integer
        Private sWorkOrder, sCopeNumber, sDragNumber, sPourRate, sWhlType, sCHONO, sDHONO, sOPERATOR1, sSIC, sSHIFTID As String
        Private datePourTime, dateSplitTime, DTBINT, DTBOUTT As Date

#End Region
#Region " Property"
        Property SplitTime() As Date
            Get
                Return dateSplitTime
            End Get
            Set(ByVal Value As Date)
                dateSplitTime = Value
            End Set
        End Property
        Property PourTime() As Date
            Get
                Return datePourTime
            End Get
            Set(ByVal Value As Date)
                datePourTime = Value
            End Set
        End Property
        Property PourRate() As String
            Get
                Return sPourRate
            End Get
            Set(ByVal Value As String)
                sPourRate = Value
            End Set
        End Property
        Property DragNumber() As String
            Get
                Return sDragNumber
            End Get
            Set(ByVal Value As String)
                sDragNumber = Value
            End Set
        End Property
        Property WhlType() As String
            Get
                Return sWhlType
            End Get
            Set(ByVal Value As String)
                sWhlType = Value
            End Set
        End Property
        Property CopeNumber() As String
            Get
                Return sCopeNumber
            End Get
            Set(ByVal Value As String)
                sCopeNumber = Value
            End Set
        End Property
        Property WorkOrder() As String
            Get
                Return sWorkOrder
            End Get
            Set(ByVal Value As String)
                sWorkOrder = Value
            End Set
        End Property
        Property CopeLife() As Integer
            Get
                Return intCopeLife
            End Get
            Set(ByVal Value As Integer)
                intCopeLife = Value
            End Set
        End Property
        Property DragLife() As Integer
            Get
                Return intDragLife
            End Get
            Set(ByVal Value As Integer)
                intDragLife = Value
            End Set
        End Property
        Property IngLife() As Integer
            Get
                Return intIngLife
            End Get
            Set(ByVal Value As Integer)
                intIngLife = Value
            End Set
        End Property
        Property PourOrder() As Integer
            Get
                Return intPourOrder
            End Get
            Set(ByVal Value As Integer)
                intPourOrder = Value
            End Set
        End Property


        Property Heat() As Long
            Get
                Return lHeat
            End Get
            Set(ByVal Value As Long)
                lHeat = Value
            End Set
        End Property

        Property CHOTMP() As Integer
            Get
                Return INTCHOTMP
            End Get
            Set(ByVal Value As Integer)
                INTCHOTMP = Value
            End Set
        End Property


        Property DHOTMP() As Integer
            Get
                Return INTDHOTMP
            End Get
            Set(ByVal Value As Integer)
                INTDHOTMP = Value
            End Set
        End Property
        Property SDTMP() As Integer
            Get
                Return INTSDTMP
            End Get
            Set(ByVal Value As Integer)
                INTSDTMP = Value
            End Set
        End Property

        Property BCTMP() As Integer
            Get
                Return INTBCTMP
            End Get
            Set(ByVal Value As Integer)
                INTBCTMP = Value
            End Set
        End Property


        Property SCTMP() As Integer
            Get
                Return INTSCTMP
            End Get
            Set(ByVal Value As Integer)
                INTSCTMP = Value
            End Set
        End Property


        Property CHONO() As String
            Get
                Return sCHONO
            End Get
            Set(ByVal Value As String)
                sCHONO = Value
            End Set
        End Property

        Property DHONO() As String
            Get
                Return sDHONO
            End Get
            Set(ByVal Value As String)
                sDHONO = Value
            End Set
        End Property

        Property TBINT() As Date
            Get
                Return TBINT
            End Get
            Set(ByVal Value As Date)
                DTBINT = Value
            End Set
        End Property
        Property TBOUTT() As Date
            Get
                Return TBOUTT
            End Get
            Set(ByVal Value As Date)
                DTBOUTT = Value
            End Set
        End Property
        Property LIM() As Integer
            Get
                Return INTLIM
            End Get
            Set(ByVal Value As Integer)
                INTLIM = Value
            End Set
        End Property
        Property SHIFTID() As String
            Get
                Return sSHIFTID
            End Get
            Set(ByVal Value As String)
                sSHIFTID = Value
            End Set
        End Property
        Property SIC() As String
            Get
                Return sSIC
            End Get
            Set(ByVal Value As String)
                sSIC = Value
            End Set
        End Property

        Property OPERATOR1() As String
            Get
                Return sOPERATOR1
            End Get
            Set(ByVal Value As String)
                sOPERATOR1 = Value
            End Set
        End Property



        Property Wheel() As Long
            Get
                Return lWheel
            End Get
            Set(ByVal Value As Long)
                lWheel = Value
            End Set
        End Property
#End Region
#Region " Methods"
        Private Sub iniVals()
            sWorkOrder = ""
            sCopeNumber = ""
            sDragNumber = ""
            sPourRate = ""
            sWhlType = ""
            intPourOrder = 0
            intCopeLife = 0
            intDragLife = 0
            intIngLife = 0
            INTCHOTMP = 100
            INTDHOTMP = 100
            INTSDTMP = 100
            INTBCTMP = 100
            INTSCTMP = 100
        End Sub
#End Region
    End Class
    Friend Class PreNPostPouring
        Inherits Heat
#Region " Fields"
        Private dateCastDate As Date

        Private sOperator, sSIC, sJMPCover, sShiftGroup, sSlag, sStopperHead, sPourTankNo, sLMLevel, sMessage As String
        Private sRiser_weight, sTube1_mfg, sTube2_mfg, sTube3_mfg As String
        Private dateLLT, dateIstImmersionTime, dateIIndImmersionTime, dateIIIrdImmersionTime, datePouring_start_time As DateTime
        Private intIstImmersionTemp, intIIndImmersionTemp, intIIIrdImmersionTemp As Integer
        Private intALStars, intALDipTemp, intTube1_life, intTube2_life, intTube3_life As Integer
        Private intLIMetal, intLadleTemp As Integer
        Private intPlunser_pressure As Double
        Private intMetalRecd, INTlwtatpouring As Double
        Private dateTubeInTime, dateTubeOutTime, dateLadleInTime As DateTime
        Private sTube1No, sTube2No, sTube3No, sTube1Con, sTube2Con, sTube3Con As String
        Private intDomeDisc, intDrain, intEndTemp, intD13, intD14, intC20, intC21, intSprueAmp, intSpruePre As Integer
        Private sCSB, sCSH, sCSP, sCSR, sDSB, sDSH, sDSP, sDSR, sTubeCondition, sRemarks, stube1conditionrmk, stube2conditionrmk, stube3conditionrmk, slesswheelrsn, sexcessprdelayrsn, sexcessprtimersn As String
        Private dateCBStartTime, dateCSStartTime, dateDSStartTime, dateSWStartTime, dateHCStartTime, dateEndTime As DateTime
        Private dateCBEndTime, dateCSEndTime, dateDSEndTime, dateSWEndTime, dateHCEndTime As DateTime
        Private decTotalPourTime, decHubWt As Decimal


#End Region
#Region " Property"
        Property TotalPourTime() As Decimal
            Get
                Return decTotalPourTime
            End Get
            Set(ByVal Value As Decimal)
                decTotalPourTime = Value
            End Set
        End Property
        Property EndTime() As DateTime
            Get
                Return dateEndTime
            End Get
            Set(ByVal Value As DateTime)
                dateEndTime = Value
            End Set
        End Property
        Property SprueAmp() As Integer
            Get
                Return intSprueAmp
            End Get
            Set(ByVal Value As Integer)
                intSprueAmp = Value
            End Set
        End Property
        Property SpruePre() As Integer
            Get
                Return intSpruePre
            End Get
            Set(ByVal Value As Integer)
                intSpruePre = Value
            End Set
        End Property
        Property TubeCondition() As String
            Get
                Return sTubeCondition
            End Get
            Set(ByVal Value As String)
                sTubeCondition = Value.Trim
            End Set
        End Property
        Property Remarks() As String
            Get
                Return sRemarks
            End Get
            Set(ByVal Value As String)
                sRemarks = Value.Trim
            End Set
        End Property
        Property CBStartTime() As DateTime
            Get
                Return dateCBStartTime
            End Get
            Set(ByVal Value As DateTime)
                dateCBStartTime = Value
            End Set
        End Property
        Property CSStartTime() As DateTime
            Get
                Return dateCSStartTime
            End Get
            Set(ByVal Value As DateTime)
                dateCSStartTime = Value
            End Set
        End Property
        Property DSStartTime() As DateTime
            Get
                Return dateDSStartTime
            End Get
            Set(ByVal Value As DateTime)
                dateDSStartTime = Value
            End Set
        End Property
        Property SWStartTime() As DateTime
            Get
                Return dateSWStartTime
            End Get
            Set(ByVal Value As DateTime)
                dateSWStartTime = Value
            End Set
        End Property
        Property HCStartTime() As DateTime
            Get
                Return dateHCStartTime
            End Get
            Set(ByVal Value As DateTime)
                dateHCStartTime = Value
            End Set
        End Property
        Property CBEndTime() As DateTime
            Get
                Return dateCBEndTime
            End Get
            Set(ByVal Value As DateTime)
                dateCBEndTime = Value
            End Set
        End Property
        Property CSEndTime() As DateTime
            Get
                Return dateCSEndTime
            End Get
            Set(ByVal Value As DateTime)
                dateCSEndTime = Value
            End Set
        End Property
        Property DSEndTime() As DateTime
            Get
                Return dateDSEndTime
            End Get
            Set(ByVal Value As DateTime)
                dateDSEndTime = Value
            End Set
        End Property
        Property SWEndTime() As DateTime
            Get
                Return dateSWEndTime
            End Get
            Set(ByVal Value As DateTime)
                dateSWEndTime = Value
            End Set
        End Property
        Property HCEndTime() As DateTime
            Get
                Return dateHCEndTime
            End Get
            Set(ByVal Value As DateTime)
                dateHCEndTime = Value
            End Set
        End Property
        Property CSB() As String
            Get
                Return sCSB
            End Get
            Set(ByVal Value As String)
                sCSB = Value.Trim
            End Set
        End Property
        Property CSH() As String
            Get
                Return sCSH
            End Get
            Set(ByVal Value As String)
                sCSH = Value.Trim
            End Set
        End Property
        Property CSP() As String
            Get
                Return sCSP
            End Get
            Set(ByVal Value As String)
                sCSP = Value.Trim
            End Set
        End Property
        Property CSR() As String
            Get
                Return sCSR
            End Get
            Set(ByVal Value As String)
                sCSR = Value.Trim
            End Set
        End Property
        Property DSB() As String
            Get
                Return sDSB
            End Get
            Set(ByVal Value As String)
                sDSB = Value.Trim
            End Set
        End Property
        Property DSH() As String
            Get
                Return sDSH
            End Get
            Set(ByVal Value As String)
                sDSH = Value.Trim
            End Set
        End Property
        Property DSP() As String
            Get
                Return sDSP
            End Get
            Set(ByVal Value As String)
                sDSP = Value.Trim
            End Set
        End Property
        Property DSR() As String
            Get
                Return sDSR
            End Get
            Set(ByVal Value As String)
                sDSR = Value.Trim
            End Set
        End Property
        Property DomeDisc() As Integer
            Get
                Return intDomeDisc
            End Get
            Set(ByVal Value As Integer)
                intDomeDisc = Value
            End Set
        End Property
        Property Drain() As Integer
            Get
                Return intDrain
            End Get
            Set(ByVal Value As Integer)
                intDrain = Value
            End Set
        End Property
        Property EndTemp() As Integer
            Get
                Return intEndTemp
            End Get
            Set(ByVal Value As Integer)
                intEndTemp = Value
            End Set
        End Property
        Property D13() As Integer
            Get
                Return intD13
            End Get
            Set(ByVal Value As Integer)
                intD13 = Value
            End Set
        End Property
        Property D14() As Integer
            Get
                Return intD14
            End Get
            Set(ByVal Value As Integer)
                intD14 = Value
            End Set
        End Property
        Property C20() As Integer
            Get
                Return intC20
            End Get
            Set(ByVal Value As Integer)
                intC20 = Value
            End Set
        End Property
        Property C21() As Integer
            Get
                Return intC21
            End Get
            Set(ByVal Value As Integer)
                intC21 = Value
            End Set
        End Property
        Property Message() As String
            Get
                Return sMessage
            End Get
            Set(ByVal Value As String)
                sMessage = Value.Trim
            End Set
        End Property
        Property MetalRecd() As Double
            Get
                Return intMetalRecd
            End Get
            Set(ByVal Value As Double)
                intMetalRecd = Value
            End Set
        End Property
        Property Tube1Con() As String
            Get
                Return sTube1Con
            End Get
            Set(ByVal Value As String)
                sTube1Con = Value.Trim
            End Set
        End Property
        Property Tube2Con() As String
            Get
                Return sTube2Con
            End Get
            Set(ByVal Value As String)
                sTube2Con = Value.Trim
            End Set
        End Property
        Property Tube3Con() As String
            Get
                Return sTube3Con
            End Get
            Set(ByVal Value As String)
                sTube3Con = Value.Trim
            End Set
        End Property
        Property Tube1No() As String
            Get
                Return sTube1No
            End Get
            Set(ByVal Value As String)
                sTube1No = Value.Trim
            End Set
        End Property
        Property Tube2No() As String
            Get
                Return sTube2No
            End Get
            Set(ByVal Value As String)
                sTube2No = Value.Trim
            End Set
        End Property
        Property Tube3No() As String
            Get
                Return sTube3No
            End Get
            Set(ByVal Value As String)
                sTube3No = Value.Trim
            End Set
        End Property
        Property LadleTemp() As Integer
            Get
                Return intLadleTemp
            End Get
            Set(ByVal Value As Integer)
                intLadleTemp = Value
            End Set
        End Property
        Property LadleInTime() As DateTime
            Get
                Return dateLadleInTime
            End Get
            Set(ByVal Value As DateTime)
                dateLadleInTime = Value
            End Set
        End Property
        Property TubeInTime() As DateTime
            Get
                Return dateTubeInTime
            End Get
            Set(ByVal Value As DateTime)
                dateTubeInTime = Value
            End Set
        End Property
        Property TubeOutTime() As DateTime
            Get
                Return dateTubeOutTime
            End Get
            Set(ByVal Value As DateTime)
                dateTubeOutTime = Value
            End Set
        End Property
        Property LIMetal() As Integer
            Get
                Return intLIMetal
            End Get
            Set(ByVal Value As Integer)
                intLIMetal = Value
            End Set
        End Property
        Property LMLevel() As String
            Get
                Return sLMLevel
            End Get
            Set(ByVal Value As String)
                sLMLevel = Value.Trim
            End Set
        End Property
        Property PourTankNo() As String
            Get
                Return sPourTankNo
            End Get
            Set(ByVal Value As String)
                sPourTankNo = Value.Trim
            End Set
        End Property
        Property Tube1_life() As Integer
            Get
                Return intTube1_life
            End Get
            Set(ByVal Value As Integer)
                intTube1_life = Value
            End Set
        End Property
        Property Tube2_life() As Integer
            Get
                Return intTube2_life
            End Get
            Set(ByVal Value As Integer)
                intTube2_life = Value
            End Set
        End Property
        Property Tube3_life() As Integer
            Get
                Return intTube3_life
            End Get
            Set(ByVal Value As Integer)
                intTube3_life = Value
            End Set
        End Property
        Property Riser_weight() As String
            Get
                Return sRiser_weight
            End Get
            Set(ByVal Value As String)
                sRiser_weight = Value.Trim
            End Set
        End Property
        Property HubWt() As Decimal
            Get
                Return decHubWt
            End Get
            Set(ByVal Value As Decimal)
                decHubWt = Value
            End Set
        End Property
        Property Tube1_mfg() As String
            Get
                Return sTube1_mfg
            End Get
            Set(ByVal Value As String)
                sTube1_mfg = Value.Trim
            End Set
        End Property
        Property Tube2_mfg() As String
            Get
                Return sTube2_mfg
            End Get
            Set(ByVal Value As String)
                sTube2_mfg = Value.Trim
            End Set
        End Property
        Property Tube3_mfg() As String
            Get
                Return sTube3_mfg
            End Get
            Set(ByVal Value As String)
                sTube3_mfg = Value.Trim
            End Set
        End Property
        Property StopperHead() As String
            Get
                Return sStopperHead
            End Get
            Set(ByVal Value As String)
                sStopperHead = Value.Trim
            End Set
        End Property
        Property Slag() As String
            Get
                Return sSlag
            End Get
            Set(ByVal Value As String)
                sSlag = Value.Trim
            End Set
        End Property
        Property ALStars() As Integer
            Get
                Return intALStars
            End Get
            Set(ByVal Value As Integer)
                intALStars = Value
            End Set
        End Property
        Property ALDipTemp() As Integer
            Get
                Return intALDipTemp
            End Get
            Set(ByVal Value As Integer)
                intALDipTemp = Value
            End Set
        End Property
        Property IIIrdImmersionTemp() As Integer
            Get
                Return intIIIrdImmersionTemp
            End Get
            Set(ByVal Value As Integer)
                intIIIrdImmersionTemp = Value
            End Set
        End Property
        Property IIndImmersionTemp() As Integer
            Get
                Return intIIndImmersionTemp
            End Get
            Set(ByVal Value As Integer)
                intIIndImmersionTemp = Value
            End Set
        End Property
        Property IstImmersionTemp() As Integer
            Get
                Return intIstImmersionTemp
            End Get
            Set(ByVal Value As Integer)
                intIstImmersionTemp = Value
            End Set
        End Property
        Property IstImmersionTime() As DateTime
            Get
                Return dateIstImmersionTime
            End Get
            Set(ByVal Value As DateTime)
                dateIstImmersionTime = Value
            End Set
        End Property
        Property IIndImmersionTime() As DateTime
            Get
                Return dateIIndImmersionTime
            End Get
            Set(ByVal Value As DateTime)
                dateIIndImmersionTime = Value
            End Set
        End Property
        Property IIIrdImmersionTime() As DateTime
            Get
                Return dateIIIrdImmersionTime
            End Get
            Set(ByVal Value As DateTime)
                dateIIIrdImmersionTime = Value
            End Set
        End Property
        Property LLT() As DateTime
            Get
                Return dateLLT
            End Get
            Set(ByVal Value As DateTime)
                dateLLT = Value
            End Set
        End Property
        Property JMPCover() As String
            Get
                Return sJMPCover
            End Get
            Set(ByVal Value As String)
                sJMPCover = Value.Trim
            End Set
        End Property
        Property SIC() As String
            Get
                Return sSIC
            End Get
            Set(ByVal Value As String)
                sSIC = Value.Trim
            End Set
        End Property
        Property ShiftGroup() As String
            Get
                Return sShiftGroup
            End Get
            Set(ByVal Value As String)
                sShiftGroup = Value.Trim
            End Set
        End Property
        Property Operator1() As String
            Get
                Return sOperator
            End Get
            Set(ByVal Value As String)
                sOperator = Value.Trim
            End Set
        End Property


        Property tube1conditionrmk() As String
            Get
                Return stube1conditionrmk
            End Get
            Set(ByVal Value As String)
                stube1conditionrmk = Value
            End Set
        End Property

        Property tube2conditionrmk() As String
            Get
                Return stube2conditionrmk
            End Get
            Set(ByVal Value As String)
                stube2conditionrmk = Value
            End Set
        End Property

        Property tube3conditionrmk() As String
            Get
                Return stube3conditionrmk
            End Get
            Set(ByVal Value As String)
                stube3conditionrmk = Value
            End Set
        End Property

        Property lesswheelrsn() As String
            Get
                Return slesswheelrsn
            End Get
            Set(ByVal Value As String)
                slesswheelrsn = Value
            End Set
        End Property

        Property excessprdelayrsn() As String
            Get
                Return sexcessprdelayrsn
            End Get
            Set(ByVal Value As String)
                sexcessprdelayrsn = Value
            End Set
        End Property

        Property excessprtimersn() As String
            Get
                Return sexcessprtimersn
            End Get
            Set(ByVal Value As String)
                sexcessprtimersn = Value
            End Set
        End Property

        Property lwtatpouring() As Integer
            Get
                Return INTlwtatpouring
            End Get
            Set(ByVal Value As Integer)
                INTlwtatpouring = Value
            End Set
        End Property
        Property CastDate() As Date
            Get
                Return dateCastDate
            End Get
            Set(ByVal Value As Date)
                dateCastDate = Value
            End Set
        End Property
        Property Pouring_start_time() As DateTime
            Get
                Return datePouring_start_time
            End Get
            Set(ByVal Value As DateTime)
                datePouring_start_time = Value
            End Set
        End Property
        Property Plunser_pressure() As Double
            Get
                Return intPlunser_pressure
            End Get
            Set(ByVal Value As Double)
                intPlunser_pressure = Value
            End Set
        End Property
#End Region
#Region " Methods"
        Private Sub iniVals()
            sShiftGroup = ""
            decHubWt = 0.0
            decTotalPourTime = ""
            intSprueAmp = ""
            intSpruePre = ""
            sTubeCondition = ""
            sRemarks = ""
            dateEndTime = "1900-01-01"
            dateCBStartTime = "1900-01-01"
            dateCSStartTime = "1900-01-01"
            dateDSStartTime = "1900-01-01"
            dateSWStartTime = "1900-01-01"
            dateHCStartTime = "1900-01-01"
            dateHCEndTime = "1900-01-01"
            dateSWEndTime = "1900-01-01"
            dateDSEndTime = "1900-01-01"
            dateCSEndTime = "1900-01-01"
            dateCBEndTime = "1900-01-01"
            sCSB = ""
            sCSH = ""
            sCSP = ""
            sCSR = ""
            sDSB = ""
            sDSH = ""
            sDSP = ""
            sDSR = ""
            intDomeDisc = ""
            intDrain = ""
            intEndTemp = ""
            intD13 = ""
            intD14 = ""
            intC20 = ""
            intC21 = ""
            sMessage = ""
            intMetalRecd = 0.0
            sTube1No = ""
            sTube2No = ""
            sTube3No = ""
            intLadleTemp = ""
            dateLadleInTime = "1900-01-01"
            dateTubeInTime = "1900-1-01"
            dateTubeOutTime = "1900-1-01"
            intLIMetal = ""
            sLMLevel = ""
            sPourTankNo = ""
            intTube1_life = ""
            intTube2_life = ""
            intTube3_life = ""
            sRiser_weight = ""
            sTube1_mfg = ""
            sTube2_mfg = ""
            sTube3_mfg = ""
            sSlag = ""
            sStopperHead = ""
            intALDipTemp = ""
            intALStars = ""
            intIstImmersionTemp = ""
            intIIndImmersionTemp = ""
            intIIIrdImmersionTemp = ""
            intPlunser_pressure = ""
            dateCastDate = "1900-01-01"
            sOperator = ""
            sJMPCover = ""
            dateLLT = "1900-01-01"
            dateIstImmersionTime = "1900-01-01"
            dateIIndImmersionTime = "1900-01-01"
            dateIIIrdImmersionTime = "1900-01-01"
            datePouring_start_time = "1900-01-01"
        End Sub
        Public Sub New(Optional ByVal HeatNumber As Long = 0)
            Me.Number = HeatNumber
            GetFurnaceCode(HeatNumber)
        End Sub
        Private Sub GetFurnaceCode(ByVal HeatNumber As Long)
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            oCmd.Parameters.Add("@furnace_code", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output
            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.CommandText = "select top 1 @furnace_code = ltrim(rtrim(furnace_code)) from mm_heatsheet_header where  heat_number =  " & HeatNumber
                oCmd.ExecuteScalar()
                Me.Furnace = IIf(IsDBNull(oCmd.Parameters("@furnace_code").Value), "", oCmd.Parameters("@furnace_code").Value)
            Catch exp As Exception
                Me.Furnace = ""
                Throw New Exception(exp.Message)
            Finally
                If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
            End Try
        End Sub
        Public Function SavePreNPostPour() As Boolean
            Dim done As Boolean
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            oCmd.Parameters.Add("@heat_number", SqlDbType.Int, 4).Value = Me.Number
            oCmd.Parameters.Add("@cast_date", SqlDbType.SmallDateTime, 4).Value = dateCastDate
            oCmd.Parameters.Add("@furnace_code", SqlDbType.VarChar, 10).Value = Me.Furnace
            oCmd.Parameters.Add("@operator_mould", SqlDbType.VarChar, 10).Value = Me.Operator1
            oCmd.Parameters.Add("@shift_supervisor", SqlDbType.VarChar, 10).Value = Me.SIC
            oCmd.Parameters.Add("@ShiftGroup", SqlDbType.VarChar, 1).Value = Me.ShiftGroup
            oCmd.Parameters.Add("@jmp_cover1", SqlDbType.VarChar, 10).Value = Me.JMPCover
            oCmd.Parameters.Add("@ladle_lift_time", SqlDbType.DateTime, 8).Value = Me.LLT
            oCmd.Parameters.Add("@tube1_immersion1_time", SqlDbType.DateTime, 8).Value = Me.IstImmersionTime
            oCmd.Parameters.Add("@tube1_immersion2_time", SqlDbType.DateTime, 8).Value = Me.IIndImmersionTime
            oCmd.Parameters.Add("@tube1_immersion3_time", SqlDbType.DateTime, 8).Value = Me.IIIrdImmersionTime
            oCmd.Parameters.Add("@tube1_immersion1_temperature", SqlDbType.Int, 4).Value = Me.IstImmersionTemp
            oCmd.Parameters.Add("@tube1_immersion2_temperature", SqlDbType.Int, 4).Value = Me.IIndImmersionTemp
            oCmd.Parameters.Add("@tube1_immersion3_temperature", SqlDbType.Int, 4).Value = Me.IIIrdImmersionTemp
            oCmd.Parameters.Add("@aluminium_stars", SqlDbType.Int, 4).Value = Me.ALStars
            oCmd.Parameters.Add("@aluminium_dip_temperature", SqlDbType.Int, 4).Value = Me.ALDipTemp
            oCmd.Parameters.Add("@slag_condition", SqlDbType.VarChar, 10).Value = Me.Slag
            oCmd.Parameters.Add("@stop_support", SqlDbType.VarChar, 10).Value = Me.StopperHead
            oCmd.Parameters.Add("@riser_weight", SqlDbType.VarChar, 10).Value = Me.Riser_weight '
            oCmd.Parameters.Add("@tube1_mfg", SqlDbType.VarChar, 10).Value = Me.Tube1_mfg
            oCmd.Parameters.Add("@tube2_mfg", SqlDbType.VarChar, 10).Value = Me.Tube2_mfg
            oCmd.Parameters.Add("@tube3_mfg", SqlDbType.VarChar, 10).Value = Me.Tube3_mfg
            oCmd.Parameters.Add("@tube1_life", SqlDbType.Int, 4).Value = Me.Tube1_life
            oCmd.Parameters.Add("@tube2_life", SqlDbType.Int, 4).Value = Me.Tube2_life
            oCmd.Parameters.Add("@tube3_life", SqlDbType.Int, 4).Value = Me.Tube3_life
            oCmd.Parameters.Add("@pouring_tank_number", SqlDbType.VarChar, 1).Value = Me.PourTankNo
            oCmd.Parameters.Add("@ladle_metal_level", SqlDbType.VarChar, 4).Value = Me.LMLevel
            oCmd.Parameters.Add("@ladle_in_time", SqlDbType.DateTime, 8).Value = Me.LadleInTime
            oCmd.Parameters.Add("@ladle_temp", SqlDbType.Int, 4).Value = Me.LadleTemp
            oCmd.Parameters.Add("@ladle_insl", SqlDbType.Int, 4).Value = Me.LIMetal
            oCmd.Parameters.Add("@tube_no_1", SqlDbType.VarChar, 10).Value = Me.Tube1No
            oCmd.Parameters.Add("@tube_no_2", SqlDbType.VarChar, 10).Value = Me.Tube2No
            oCmd.Parameters.Add("@tube_no_3", SqlDbType.VarChar, 10).Value = Me.Tube3No 'tube_no_3_con

            oCmd.Parameters.Add("@tube_no_1_con", SqlDbType.VarChar, 10).Value = Me.Tube1Con
            oCmd.Parameters.Add("@tube_no_2_con", SqlDbType.VarChar, 10).Value = Me.Tube2Con
            oCmd.Parameters.Add("@tube_no_3_con", SqlDbType.VarChar, 10).Value = Me.Tube3Con

            oCmd.Parameters.Add("@tube1_in_time", SqlDbType.DateTime, 8).Value = Me.TubeInTime
            oCmd.Parameters.Add("@tube2_in_time", SqlDbType.DateTime, 8).Value = Me.TubeInTime
            oCmd.Parameters.Add("@tube3_in_time", SqlDbType.DateTime, 8).Value = Me.TubeInTime
            oCmd.Parameters.Add("@tube1_out_time", SqlDbType.DateTime, 8).Value = Me.TubeOutTime
            oCmd.Parameters.Add("@tube2_out_time", SqlDbType.DateTime, 8).Value = Me.TubeOutTime
            oCmd.Parameters.Add("@tube3_out_time", SqlDbType.DateTime, 8).Value = Me.TubeOutTime
            oCmd.Parameters.Add("@metal_recieved", SqlDbType.Float, 8).Value = Me.MetalRecd

            oCmd.Parameters.Add("@dome_disc_used", SqlDbType.Int, 4).Value = Me.DomeDisc
            oCmd.Parameters.Add("@EndTime", SqlDbType.DateTime, 8).Value = Me.EndTime
            oCmd.Parameters.Add("@end_temperature", SqlDbType.Int, 4).Value = Me.EndTemp
            oCmd.Parameters.Add("@drain_mm", SqlDbType.Int, 4).Value = Me.Drain
            oCmd.Parameters.Add("@d13_temperature", SqlDbType.Int, 4).Value = Me.D13
            oCmd.Parameters.Add("@d14_temperature", SqlDbType.Int, 4).Value = Me.D14
            oCmd.Parameters.Add("@c20_temperature", SqlDbType.Int, 4).Value = Me.C20
            oCmd.Parameters.Add("@c21_temperature", SqlDbType.Int, 4).Value = Me.C21
            oCmd.Parameters.Add("@cope_spray_r", SqlDbType.VarChar, 50).Value = Me.CSR
            oCmd.Parameters.Add("@cope_spray_p", SqlDbType.VarChar, 50).Value = Me.CSP
            oCmd.Parameters.Add("@cope_spray_h", SqlDbType.VarChar, 50).Value = Me.CSH
            oCmd.Parameters.Add("@cope_spray_b", SqlDbType.VarChar, 50).Value = Me.CSB
            oCmd.Parameters.Add("@drag_spray_r", SqlDbType.VarChar, 50).Value = Me.DSR
            oCmd.Parameters.Add("@drag_spray_h", SqlDbType.VarChar, 50).Value = Me.DSH
            oCmd.Parameters.Add("@drag_spray_p", SqlDbType.VarChar, 50).Value = Me.DSP
            oCmd.Parameters.Add("@drag_spray_b", SqlDbType.VarChar, 50).Value = Me.DSB
            oCmd.Parameters.Add("@drag_spray_starttime", SqlDbType.DateTime, 8).Value = Me.DSStartTime
            oCmd.Parameters.Add("@drag_spray_endtime", SqlDbType.DateTime, 8).Value = Me.DSEndTime
            oCmd.Parameters.Add("@cope_drag_spray_sttime", SqlDbType.DateTime, 8).Value = Me.CSStartTime
            oCmd.Parameters.Add("@cope_drag_spray_endtime", SqlDbType.DateTime, 8).Value = Me.CSEndTime
            oCmd.Parameters.Add("@spru_wash_sttime", SqlDbType.DateTime, 8).Value = Me.SWStartTime
            oCmd.Parameters.Add("@spru_wash_endtime", SqlDbType.DateTime, 8).Value = Me.SWEndTime
            oCmd.Parameters.Add("@hub_cut_sttime", SqlDbType.DateTime, 8).Value = Me.HCStartTime
            oCmd.Parameters.Add("@hub_cut_endtime", SqlDbType.DateTime, 8).Value = Me.HCEndTime
            oCmd.Parameters.Add("@core_bak_sttime", SqlDbType.DateTime, 8).Value = Me.CBStartTime
            oCmd.Parameters.Add("@core_bak_endtime", SqlDbType.DateTime, 8).Value = Me.CBEndTime
            oCmd.Parameters.Add("@tube_condition", SqlDbType.VarChar, 50).Value = Me.TubeCondition
            oCmd.Parameters.Add("@remarks", SqlDbType.VarChar, 8000).Value = Me.Remarks
            oCmd.Parameters.Add("@sprue_ampere", SqlDbType.Int, 4).Value = Me.SprueAmp
            oCmd.Parameters.Add("@spure_pressure", SqlDbType.Int, 4).Value = Me.SpruePre
            oCmd.Parameters.Add("@total_pour_time", SqlDbType.Float, 8).Value = Me.TotalPourTime
            oCmd.Parameters.Add("@pouring_start_time", SqlDbType.Float, 8).Value = Me.Pouring_start_time
            oCmd.Parameters.Add("@plunser_pressure", SqlDbType.Float, 8).Value = Me.Plunser_pressure
            Dim dt1 As DataTable
            dt1 = RWF.tables.getWheelsCopesDragsUsed(Me.Number)
            oCmd.Parameters.Add("@wheels_cast_cope", SqlDbType.Int, 4).Value = IIf(IsDBNull(dt1.Rows(0)("CopesUsed")), "0", dt1.Rows(0)("CopesUsed"))
            oCmd.Parameters.Add("@wheels_cast_drag", SqlDbType.Int, 4).Value = IIf(IsDBNull(dt1.Rows(0)("DragsUsed")), "0", dt1.Rows(0)("DragsUsed"))
            oCmd.Parameters.Add("@total_wheels_poured", SqlDbType.Int, 4).Value = IIf(IsDBNull(dt1.Rows(0)("WhlsCast")), "0", dt1.Rows(0)("WhlsCast"))
            dt1 = Nothing

            oCmd.Parameters.Add("@cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output
            oCmd.CommandText = " select @cnt = count(*) from mm_pre_pouring where heat_number = @heat_number"
            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.Transaction = oCmd.Connection.BeginTransaction
                oCmd.ExecuteScalar()
                If IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value) = 0 Then
                    oCmd.CommandText = " insert into mm_pre_pouring ( cast_date , heat_number , furnace_code , " &
                        " operator_mould , shift_supervisor , jmp_cover1 , ladle_lift_time , tube1_immersion1_time , " &
                        " tube1_immersion1_temperature , tube1_immersion2_time , tube1_immersion2_temperature , " &
                        " tube1_immersion3_time , tube1_immersion3_temperature , aluminium_stars , " &
                        " aluminium_dip_temperature , slag_condition , stop_support ,  " &
                        " riser_weight , tube1_mfg , tube2_mfg , tube3_mfg , tube1_life , tube2_life , tube3_life , " &
                        " pouring_tank_number , ladle_metal_level , ladle_insl , tube1_in_time , tube2_in_time , " &
                        " tube3_in_time , tube1_out_time , tube2_out_time , tube3_out_time , ladle_in_time , " &
                        " ladle_temp , tube_no_1 , tube_no_2 , tube_no_3 , metal_recieved , tube_no_1_con , tube_no_2_con , tube_no_3_con ) " &
                        " values ( @cast_date , @heat_number , @furnace_code , @operator_mould , @shift_supervisor , " &
                        " @jmp_cover1 , @ladle_lift_time , @tube1_immersion1_time , @tube1_immersion1_temperature , " &
                        " @tube1_immersion2_time, @tube1_immersion2_temperature ,  @tube1_immersion3_time , " &
                        " @tube1_immersion3_temperature , @aluminium_stars , @aluminium_dip_temperature , " &
                        " @slag_condition , @stop_support , @riser_weight , @tube1_mfg , @tube2_mfg , @tube3_mfg ," &
                        " @tube1_life , @tube2_life , @tube3_life , @pouring_tank_number , @ladle_metal_level , " &
                        " @ladle_insl , @tube1_in_time , @tube2_in_time , @tube3_in_time , @tube1_out_time , " &
                        " @tube2_out_time , @tube3_out_time , @ladle_in_time , @ladle_temp , @tube_no_1 , @tube_no_2 , @tube_no_3  , @metal_recieved , " &
                        " @tube_no_1_con , @tube_no_2_con , @tube_no_3_con ) "
                Else
                    oCmd.CommandText = " update mm_pre_pouring set cast_date = @cast_date , furnace_code = @furnace_code , operator_mould = @operator_mould , " &
                        " shift_supervisor = @shift_supervisor , jmp_cover1 = @jmp_cover1 , ladle_lift_time = @ladle_lift_time ," &
                        " tube1_immersion1_time = @tube1_immersion1_time , tube1_immersion1_temperature = @tube1_immersion1_temperature , " &
                        " tube1_immersion2_time = @tube1_immersion2_time , tube1_immersion2_temperature = @tube1_immersion2_temperature ," &
                        " tube1_immersion3_time = @tube1_immersion3_time , tube1_immersion3_temperature = @tube1_immersion3_temperature , " &
                        " aluminium_stars = @aluminium_stars , aluminium_dip_temperature = @aluminium_dip_temperature , " &
                        " slag_condition = @slag_condition , stop_support = @stop_support , riser_weight = @riser_weight , " &
                        " tube1_mfg = @tube1_mfg , tube2_mfg = @tube2_mfg , tube3_mfg = @tube3_mfg ," &
                        " tube1_life = @tube1_life , tube2_life = @tube2_life , tube3_life = @tube3_life ," &
                        " pouring_tank_number = @pouring_tank_number , ladle_metal_level = @ladle_metal_level , " &
                        " ladle_insl = @ladle_insl , tube1_in_time = @tube1_in_time , tube2_in_time = @tube2_in_time ," &
                        " tube3_in_time = @tube3_in_time , tube1_out_time = @tube1_out_time , tube2_out_time = @tube2_out_time , " &
                        " tube3_out_time = @tube3_out_time , ladle_in_time = @ladle_in_time , ladle_temp = @ladle_temp , " &
                        " tube_no_1 = @tube_no_1 , tube_no_2 = @tube_no_2 , tube_no_3 = @tube_no_3 , metal_recieved = @metal_recieved , " &
                        " tube_no_1_con = @tube_no_1_con , tube_no_2_con = @tube_no_2_con , tube_no_3_con = @tube_no_3_con " &
                        " where heat_number = @heat_number "
                End If

                If oCmd.ExecuteNonQuery = 1 Then
                    oCmd.Parameters("@cnt").Value = 0
                    oCmd.CommandText = " select @cnt = count(*) from mm_post_pouring where heat_number = @heat_number"
                    oCmd.ExecuteScalar()
                    If IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value) = 0 Then
                        oCmd.CommandText = " insert into mm_post_pouring ( heat_number ,  dome_disc_used ,  end_temperature ,  drain_mm ,  d13_temperature , " &
                            " end_time , d14_temperature ,  c20_temperature ,  c21_temperature ,  cope_spray_r ,  cope_spray_p ,  " &
                            " cope_spray_h ,  cope_spray_b ,  drag_spray_r ,  drag_spray_h ,  drag_spray_p ,  drag_spray_b ,  " &
                            " drag_spray_starttime ,  drag_spray_endtime ,  cope_drag_spray_sttime ,  cope_drag_spray_endtime , " &
                            " spru_wash_sttime ,  spru_wash_endtime ,  hub_cut_sttime ,  hub_cut_endtime ,  core_bak_sttime ,  " &
                            " core_bak_endtime ,  tube_condition ,  remarks ,  sprue_ampere ,  spure_pressure , total_pour_time , " &
                            " wheels_cast_cope , wheels_cast_drag , total_wheels_poured ) values ( " &
                            " @heat_number ,  @dome_disc_used ,  @end_temperature ,  @drain_mm ,  @d13_temperature ," &
                            " @EndTime , @d14_temperature ,  @c20_temperature ,  @c21_temperature ,  @cope_spray_r ,  @cope_spray_p , " &
                            " @cope_spray_h ,  @cope_spray_b ,  @drag_spray_r ,  @drag_spray_h ,  @drag_spray_p ,  @drag_spray_b ,  " &
                            " @drag_spray_starttime ,  @drag_spray_endtime ,  @cope_drag_spray_sttime ,  @cope_drag_spray_endtime ," &
                            " @spru_wash_sttime ,  @spru_wash_endtime ,  @hub_cut_sttime ,  @hub_cut_endtime ,  @core_bak_sttime ,  " &
                            " @core_bak_endtime ,  @tube_condition ,  @remarks ,  @sprue_ampere ,  @spure_pressure , " &
                            " @total_pour_time , @wheels_cast_cope , @wheels_cast_drag , @total_wheels_poured ) "
                    Else
                        oCmd.CommandText = " update mm_post_pouring set  dome_disc_used = @dome_disc_used ,  end_temperature = @end_temperature , " &
                            " end_time = @EndTime , drain_mm = @drain_mm ,  d13_temperature = @d13_temperature , " &
                            " d14_temperature = @d14_temperature ,  c20_temperature = @c20_temperature ,  " &
                            " c21_temperature = @c21_temperature ,  cope_spray_r = @cope_spray_r ,  cope_spray_p = @cope_spray_p ,  " &
                            " cope_spray_h = @cope_spray_h ,  cope_spray_b = @cope_spray_b ,  drag_spray_r = @drag_spray_r , " &
                            " drag_spray_h = @drag_spray_h ,  drag_spray_p = @drag_spray_p ,  drag_spray_b = @drag_spray_b ,  " &
                            " drag_spray_starttime = @drag_spray_starttime ,  drag_spray_endtime = @drag_spray_endtime , " &
                            " cope_drag_spray_sttime = @cope_drag_spray_sttime ,  cope_drag_spray_endtime = @cope_drag_spray_endtime , " &
                            " spru_wash_sttime = @spru_wash_sttime ,  spru_wash_endtime = @spru_wash_endtime ,  " &
                            " hub_cut_sttime = @hub_cut_sttime ,  hub_cut_endtime = @hub_cut_endtime ,  core_bak_sttime = @core_bak_sttime ,  " &
                            " core_bak_endtime = @core_bak_endtime ,  tube_condition = @tube_condition ,  remarks = @remarks , " &
                            " sprue_ampere = @sprue_ampere ,  spure_pressure =  @spure_pressure , " &
                            " total_pour_time = @total_pour_time , wheels_cast_cope = @wheels_cast_cope , " &
                            " wheels_cast_drag = @wheels_cast_drag , total_wheels_poured = @total_wheels_poured where heat_number = @heat_number "
                    End If
                    If oCmd.ExecuteNonQuery = 1 Then done = True
                    oCmd.Parameters("@cnt").Value = 0
                    oCmd.CommandText = " select @cnt = count(*) from mm_pouring_group where heat_number = @heat_number"
                    oCmd.ExecuteScalar()
                    If IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value) = 0 Then
                        oCmd.CommandText = " insert into mm_pouring_group ( heat_number , ShiftGroup ) values ( @heat_number , @ShiftGroup ) "
                    Else
                        oCmd.CommandText = " update mm_pouring_group set ShiftGroup = @ShiftGroup where heat_number = @heat_number "
                    End If
                    oCmd.ExecuteNonQuery()
                End If
            Catch exp As Exception
                sMessage = exp.Message
            Finally
                If done Then
                    oCmd.Transaction.Commit()
                Else
                    oCmd.Transaction.Rollback()
                End If
                oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
            End Try
            Return done
        End Function
        Public Function SavePrePour1(ByVal heat As Integer, ByVal dateCastDate As Date, ByVal Furnace As String, ByVal Operator1 As String, ByVal SIC As String, ByVal JMPCover As String, ByVal LLT As Date, ByVal IstImmersionTime As Date, ByVal IIndImmersionTime As Date, ByVal IIIrdImmersionTime As Date, ByVal IstImmersionTemp As Integer, ByVal IIndImmersionTemp As Integer, ByVal IIIrdImmersionTemp As Integer, ByVal ALStars As Integer, ByVal ALDipTemp As Integer, ByVal Slag As String, ByVal StopperHead As String, ByVal Riser_weight As String, ByVal Tube1_mfg As String, ByVal Tube2_mfg As String, ByVal Tube3_mfg As String, ByVal Tube1_life As String, ByVal Tube2_life As Integer, ByVal Tube3_life As Integer, ByVal PourTankNo As Integer, ByVal LMLevel As String, ByVal LadleInTime As Date, ByVal LadleTemp As Integer, ByVal ladle_insl As Integer, ByVal TubeInTime As Date, ByVal TubeOutTime As Date, ByVal MetalRecd As Double, ByVal D13 As Integer, ByVal D14 As Integer, ByVal C20 As Integer, ByVal C21 As Integer, ByVal pouring_start_time As Date, ByVal plunser_pressure As Double, ByVal probe_height As Double) As Boolean
            Dim done As Boolean
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
            Try
                oCmd.Parameters.Add("@heat_number", SqlDbType.Int, 4).Value = heat
                oCmd.Parameters.Add("@cast_date", SqlDbType.SmallDateTime, 4).Value = dateCastDate
                oCmd.Parameters.Add("@furnace_code", SqlDbType.VarChar, 10).Value = Furnace
                oCmd.Parameters.Add("@operator_mould", SqlDbType.VarChar, 10).Value = Operator1
                oCmd.Parameters.Add("@shift_supervisor", SqlDbType.VarChar, 10).Value = SIC
                oCmd.Parameters.Add("@jmp_cover1", SqlDbType.VarChar, 10).Value = JMPCover
                oCmd.Parameters.Add("@ladle_lift_time", SqlDbType.DateTime, 8).Value = LLT
                oCmd.Parameters.Add("@tube1_immersion1_time", SqlDbType.DateTime, 8).Value = IstImmersionTime
                oCmd.Parameters.Add("@tube1_immersion2_time", SqlDbType.DateTime, 8).Value = IIndImmersionTime
                oCmd.Parameters.Add("@tube1_immersion3_time", SqlDbType.DateTime, 8).Value = IIIrdImmersionTime
                oCmd.Parameters.Add("@tube1_immersion1_temperature", SqlDbType.Int, 4).Value = IstImmersionTemp
                oCmd.Parameters.Add("@tube1_immersion2_temperature", SqlDbType.Int, 4).Value = IIndImmersionTemp
                oCmd.Parameters.Add("@tube1_immersion3_temperature", SqlDbType.Int, 4).Value = IIIrdImmersionTemp
                oCmd.Parameters.Add("@aluminium_stars", SqlDbType.Int, 4).Value = ALStars
                oCmd.Parameters.Add("@aluminium_dip_temperature", SqlDbType.Int, 4).Value = ALDipTemp
                oCmd.Parameters.Add("@slag_condition", SqlDbType.VarChar, 10).Value = Slag
                oCmd.Parameters.Add("@stop_support", SqlDbType.VarChar, 10).Value = StopperHead
                oCmd.Parameters.Add("@riser_weight", SqlDbType.VarChar, 10).Value = Riser_weight
                oCmd.Parameters.Add("@tube1_mfg", SqlDbType.VarChar, 10).Value = Tube1_mfg
                oCmd.Parameters.Add("@tube2_mfg", SqlDbType.VarChar, 10).Value = Tube2_mfg
                oCmd.Parameters.Add("@tube3_mfg", SqlDbType.VarChar, 10).Value = Tube3_mfg
                oCmd.Parameters.Add("@tube1_life", SqlDbType.Int, 4).Value = Tube1_life
                oCmd.Parameters.Add("@tube2_life", SqlDbType.Int, 4).Value = Tube2_life
                oCmd.Parameters.Add("@tube3_life", SqlDbType.Int, 4).Value = Tube3_life
                oCmd.Parameters.Add("@pouring_tank_number", SqlDbType.VarChar, 1).Value = PourTankNo
                oCmd.Parameters.Add("@ladle_metal_level", SqlDbType.VarChar, 4).Value = LMLevel
                oCmd.Parameters.Add("@ladle_in_time", SqlDbType.DateTime, 8).Value = LadleInTime
                oCmd.Parameters.Add("@ladle_temp", SqlDbType.Int, 4).Value = LadleTemp
                oCmd.Parameters.Add("@ladle_insl", SqlDbType.Int, 4).Value = ladle_insl
                oCmd.Parameters.Add("@tube1_in_time", SqlDbType.DateTime, 8).Value = TubeInTime
                oCmd.Parameters.Add("@tube2_in_time", SqlDbType.DateTime, 8).Value = TubeInTime
                oCmd.Parameters.Add("@tube3_in_time", SqlDbType.DateTime, 8).Value = TubeInTime
                oCmd.Parameters.Add("@tube1_out_time", SqlDbType.DateTime, 8).Value = TubeOutTime
                oCmd.Parameters.Add("@tube2_out_time", SqlDbType.DateTime, 8).Value = TubeOutTime
                oCmd.Parameters.Add("@tube3_out_time", SqlDbType.DateTime, 8).Value = TubeOutTime
                oCmd.Parameters.Add("@metal_recieved", SqlDbType.Float, 8).Value = MetalRecd
                oCmd.Parameters.Add("@d13_temperature", SqlDbType.Int, 4).Value = D13
                oCmd.Parameters.Add("@d14_temperature", SqlDbType.Int, 4).Value = D14
                oCmd.Parameters.Add("@c20_temperature", SqlDbType.Int, 4).Value = C20
                oCmd.Parameters.Add("@c21_temperature", SqlDbType.Int, 4).Value = C21
                oCmd.Parameters.Add("@pouring_start_time", SqlDbType.DateTime, 8).Value = pouring_start_time
                oCmd.Parameters.Add("@plunser_pressure", SqlDbType.Float, 8).Value = plunser_pressure
                oCmd.Parameters.Add("@probe_height", SqlDbType.Float, 8).Value = probe_height



                oCmd.Parameters.Add("@cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output
                oCmd.CommandText = " select @cnt = count(*) from mm_pre_pouring where heat_number = @heat_number"
            Catch exp As Exception
                sMessage = exp.Message
            End Try

            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.Transaction = oCmd.Connection.BeginTransaction
                oCmd.ExecuteScalar()

                If IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value) = 0 Then
                    oCmd.CommandText = " insert into mm_pre_pouring ( cast_date , heat_number , furnace_code , " &
                        " operator_mould , shift_supervisor , jmp_cover1 , ladle_lift_time , tube1_immersion1_time , " &
                        " tube1_immersion1_temperature , tube1_immersion2_time , tube1_immersion2_temperature , " &
                        " tube1_immersion3_time , tube1_immersion3_temperature , aluminium_stars , " &
                        " aluminium_dip_temperature , slag_condition , stop_support ,  " &
                        " riser_weight , tube1_mfg , tube2_mfg , tube3_mfg , tube1_life , tube2_life , tube3_life , " &
                        " pouring_tank_number , ladle_metal_level , ladle_insl , tube1_in_time , tube2_in_time , " &
                        " tube3_in_time , tube1_out_time , tube2_out_time , tube3_out_time , ladle_in_time , " &
                        " ladle_temp , metal_recieved , D13, D14, C20, C21, pouring_start_time, plunser_pressure, " &
                        "probe_height ) " &
                        " values ( @cast_date , @heat_number , @furnace_code , @operator_mould , @shift_supervisor , " &
                        " @jmp_cover1 , @ladle_lift_time , @tube1_immersion1_time , @tube1_immersion1_temperature , " &
                        " @tube1_immersion2_time, @tube1_immersion2_temperature ,  @tube1_immersion3_time , " &
                        " @tube1_immersion3_temperature , @aluminium_stars , @aluminium_dip_temperature , " &
                        " @slag_condition , @stop_support , @riser_weight , @tube1_mfg , @tube2_mfg , @tube3_mfg ," &
                        " @tube1_life , @tube2_life , @tube3_life , @pouring_tank_number , @ladle_metal_level , " &
                        " @ladle_insl , @tube1_in_time , @tube2_in_time , @tube3_in_time , @tube1_out_time , " &
                        " @tube2_out_time , @tube3_out_time , @ladle_in_time , @ladle_temp ,  @metal_recieved , " &
                        " @D13, @D14, @C20, @C21, @pouring_start_time, @plunser_pressure, @probe_height ) "
                Else
                    oCmd.CommandText = " update mm_pre_pouring set cast_date = @cast_date , furnace_code = @furnace_code , operator_mould = @operator_mould , " &
                        " shift_supervisor = @shift_supervisor , jmp_cover1 = @jmp_cover1 , ladle_lift_time = @ladle_lift_time ," &
                        " tube1_immersion1_time = @tube1_immersion1_time , tube1_immersion1_temperature = @tube1_immersion1_temperature , " &
                        " tube1_immersion2_time = @tube1_immersion2_time , tube1_immersion2_temperature = @tube1_immersion2_temperature ," &
                        " tube1_immersion3_time = @tube1_immersion3_time , tube1_immersion3_temperature = @tube1_immersion3_temperature , " &
                        " aluminium_stars = @aluminium_stars , aluminium_dip_temperature = @aluminium_dip_temperature , " &
                        " slag_condition = @slag_condition , stop_support = @stop_support , riser_weight = @riser_weight , " &
                        " tube1_mfg = @tube1_mfg , tube2_mfg = @tube2_mfg , tube3_mfg = @tube3_mfg ," &
                        " tube1_life = @tube1_life , tube2_life = @tube2_life , tube3_life = @tube3_life ," &
                        " pouring_tank_number = @pouring_tank_number , ladle_metal_level = @ladle_metal_level , " &
                        " ladle_insl = @ladle_insl , tube1_in_time = @tube1_in_time , tube2_in_time = @tube2_in_time ," &
                        " tube3_in_time = @tube3_in_time , tube1_out_time = @tube1_out_time , tube2_out_time = @tube2_out_time , " &
                        " tube3_out_time = @tube3_out_time , ladle_in_time = @ladle_in_time , ladle_temp = @ladle_temp , " &
                        " metal_recieved = @metal_recieved ,D13=@D13, D14=@D14, C20=@C20, C21=@C21, " &
                        " pouring_start_time=@pouring_start_time, plunser_pressure=@plunser_pressure, probe_height=@probe_height " &
                        " where heat_number = @heat_number "
                End If

                If oCmd.ExecuteNonQuery = 1 Then done = True
                oCmd.Parameters("@cnt").Value = 0
                oCmd.CommandText = " select @cnt = count(*) from mm_pouring_group where heat_number = @heat_number"
                oCmd.ExecuteScalar()
                If IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value) = 0 Then
                    oCmd.CommandText = " insert into mm_pouring_group ( heat_number , ShiftGroup ) values ( @heat_number , @ShiftGroup ) "
                Else
                    oCmd.CommandText = " update mm_pouring_group set ShiftGroup = @ShiftGroup where heat_number = @heat_number "
                End If
                oCmd.ExecuteNonQuery()

            Catch exp As Exception
                sMessage = exp.Message
            Finally
                If done Then
                    oCmd.Transaction.Commit()
                Else
                    oCmd.Transaction.Rollback()
                End If
                oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
            End Try
            Return done
        End Function

        Public Function SavePrePour() As Boolean
            Dim done As Boolean
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            oCmd.Parameters.Add("@heat_number", SqlDbType.Int, 4).Value = Me.Number
            oCmd.Parameters.Add("@cast_date", SqlDbType.SmallDateTime, 4).Value = dateCastDate
            oCmd.Parameters.Add("@furnace_code", SqlDbType.VarChar, 10).Value = Me.Furnace
            oCmd.Parameters.Add("@operator_mould", SqlDbType.VarChar, 10).Value = Me.Operator1
            oCmd.Parameters.Add("@shift_supervisor", SqlDbType.VarChar, 10).Value = Me.SIC
            oCmd.Parameters.Add("@ShiftGroup", SqlDbType.VarChar, 1).Value = Me.ShiftGroup
            oCmd.Parameters.Add("@jmp_cover1", SqlDbType.VarChar, 10).Value = Me.JMPCover
            oCmd.Parameters.Add("@ladle_lift_time", SqlDbType.DateTime, 8).Value = Me.LLT
            oCmd.Parameters.Add("@tube1_immersion1_time", SqlDbType.DateTime, 8).Value = Me.IstImmersionTime
            oCmd.Parameters.Add("@tube1_immersion2_time", SqlDbType.DateTime, 8).Value = Me.IIndImmersionTime
            oCmd.Parameters.Add("@tube1_immersion3_time", SqlDbType.DateTime, 8).Value = Me.IIIrdImmersionTime
            oCmd.Parameters.Add("@tube1_immersion1_temperature", SqlDbType.Int, 4).Value = Me.IstImmersionTemp
            oCmd.Parameters.Add("@tube1_immersion2_temperature", SqlDbType.Int, 4).Value = Me.IIndImmersionTemp
            oCmd.Parameters.Add("@tube1_immersion3_temperature", SqlDbType.Int, 4).Value = Me.IIIrdImmersionTemp
            oCmd.Parameters.Add("@aluminium_stars", SqlDbType.Int, 4).Value = Me.ALStars
            oCmd.Parameters.Add("@aluminium_dip_temperature", SqlDbType.Int, 4).Value = Me.ALDipTemp
            oCmd.Parameters.Add("@slag_condition", SqlDbType.VarChar, 10).Value = Me.Slag
            oCmd.Parameters.Add("@stop_support", SqlDbType.VarChar, 10).Value = Me.StopperHead
            oCmd.Parameters.Add("@riser_weight", SqlDbType.VarChar, 10).Value = Me.Riser_weight '
            oCmd.Parameters.Add("@tube1_mfg", SqlDbType.VarChar, 10).Value = Me.Tube1_mfg
            oCmd.Parameters.Add("@tube2_mfg", SqlDbType.VarChar, 10).Value = Me.Tube2_mfg
            oCmd.Parameters.Add("@tube3_mfg", SqlDbType.VarChar, 10).Value = Me.Tube3_mfg
            oCmd.Parameters.Add("@tube1_life", SqlDbType.Int, 4).Value = Me.Tube1_life
            oCmd.Parameters.Add("@tube2_life", SqlDbType.Int, 4).Value = Me.Tube2_life
            oCmd.Parameters.Add("@tube3_life", SqlDbType.Int, 4).Value = Me.Tube3_life
            oCmd.Parameters.Add("@pouring_tank_number", SqlDbType.VarChar, 1).Value = Me.PourTankNo
            oCmd.Parameters.Add("@ladle_metal_level", SqlDbType.VarChar, 4).Value = Me.LMLevel
            oCmd.Parameters.Add("@ladle_in_time", SqlDbType.DateTime, 8).Value = Me.LadleInTime
            oCmd.Parameters.Add("@ladle_temp", SqlDbType.Int, 4).Value = Me.LadleTemp
            oCmd.Parameters.Add("@ladle_insl", SqlDbType.Int, 4).Value = Me.LIMetal
            oCmd.Parameters.Add("@tube_no_1", SqlDbType.VarChar, 10).Value = Me.Tube1No
            oCmd.Parameters.Add("@tube_no_2", SqlDbType.VarChar, 10).Value = Me.Tube2No
            oCmd.Parameters.Add("@tube_no_3", SqlDbType.VarChar, 10).Value = Me.Tube3No 'tube_no_3_con

            oCmd.Parameters.Add("@tube_no_1_con", SqlDbType.VarChar, 10).Value = Me.Tube1Con
            oCmd.Parameters.Add("@tube_no_2_con", SqlDbType.VarChar, 10).Value = Me.Tube2Con
            oCmd.Parameters.Add("@tube_no_3_con", SqlDbType.VarChar, 10).Value = Me.Tube3Con

            oCmd.Parameters.Add("@tube1_in_time", SqlDbType.DateTime, 8).Value = Me.TubeInTime
            oCmd.Parameters.Add("@tube2_in_time", SqlDbType.DateTime, 8).Value = Me.TubeInTime
            oCmd.Parameters.Add("@tube3_in_time", SqlDbType.DateTime, 8).Value = Me.TubeInTime
            oCmd.Parameters.Add("@tube1_out_time", SqlDbType.DateTime, 8).Value = Me.TubeOutTime
            oCmd.Parameters.Add("@tube2_out_time", SqlDbType.DateTime, 8).Value = Me.TubeOutTime
            oCmd.Parameters.Add("@tube3_out_time", SqlDbType.DateTime, 8).Value = Me.TubeOutTime
            oCmd.Parameters.Add("@metal_recieved", SqlDbType.Float, 8).Value = Me.MetalRecd

            oCmd.Parameters.Add("@dome_disc_used", SqlDbType.Int, 4).Value = Me.DomeDisc
            oCmd.Parameters.Add("@EndTime", SqlDbType.DateTime, 8).Value = Me.EndTime
            oCmd.Parameters.Add("@end_temperature", SqlDbType.Int, 4).Value = Me.EndTemp
            oCmd.Parameters.Add("@drain_mm", SqlDbType.Int, 4).Value = Me.Drain
            oCmd.Parameters.Add("@d13_temperature", SqlDbType.Int, 4).Value = Me.D13
            oCmd.Parameters.Add("@d14_temperature", SqlDbType.Int, 4).Value = Me.D14
            oCmd.Parameters.Add("@c20_temperature", SqlDbType.Int, 4).Value = Me.C20
            oCmd.Parameters.Add("@c21_temperature", SqlDbType.Int, 4).Value = Me.C21
            oCmd.Parameters.Add("@cope_spray_r", SqlDbType.VarChar, 50).Value = Me.CSR
            oCmd.Parameters.Add("@cope_spray_p", SqlDbType.VarChar, 50).Value = Me.CSP
            oCmd.Parameters.Add("@cope_spray_h", SqlDbType.VarChar, 50).Value = Me.CSH
            oCmd.Parameters.Add("@cope_spray_b", SqlDbType.VarChar, 50).Value = Me.CSB
            oCmd.Parameters.Add("@drag_spray_r", SqlDbType.VarChar, 50).Value = Me.DSR
            oCmd.Parameters.Add("@drag_spray_h", SqlDbType.VarChar, 50).Value = Me.DSH
            oCmd.Parameters.Add("@drag_spray_p", SqlDbType.VarChar, 50).Value = Me.DSP
            oCmd.Parameters.Add("@drag_spray_b", SqlDbType.VarChar, 50).Value = Me.DSB
            oCmd.Parameters.Add("@drag_spray_starttime", SqlDbType.DateTime, 8).Value = Me.DSStartTime
            oCmd.Parameters.Add("@drag_spray_endtime", SqlDbType.DateTime, 8).Value = Me.DSEndTime
            oCmd.Parameters.Add("@cope_drag_spray_sttime", SqlDbType.DateTime, 8).Value = Me.CSStartTime
            oCmd.Parameters.Add("@cope_drag_spray_endtime", SqlDbType.DateTime, 8).Value = Me.CSEndTime
            oCmd.Parameters.Add("@spru_wash_sttime", SqlDbType.DateTime, 8).Value = Me.SWStartTime
            oCmd.Parameters.Add("@spru_wash_endtime", SqlDbType.DateTime, 8).Value = Me.SWEndTime
            oCmd.Parameters.Add("@hub_cut_sttime", SqlDbType.DateTime, 8).Value = Me.HCStartTime
            oCmd.Parameters.Add("@hub_cut_endtime", SqlDbType.DateTime, 8).Value = Me.HCEndTime
            oCmd.Parameters.Add("@core_bak_sttime", SqlDbType.DateTime, 8).Value = Me.CBStartTime
            oCmd.Parameters.Add("@core_bak_endtime", SqlDbType.DateTime, 8).Value = Me.CBEndTime
            oCmd.Parameters.Add("@tube_condition", SqlDbType.VarChar, 50).Value = Me.TubeCondition
            oCmd.Parameters.Add("@remarks", SqlDbType.VarChar, 8000).Value = Me.Remarks
            oCmd.Parameters.Add("@sprue_ampere", SqlDbType.Int, 4).Value = Me.SprueAmp
            oCmd.Parameters.Add("@spure_pressure", SqlDbType.Int, 4).Value = Me.SpruePre
            oCmd.Parameters.Add("@total_pour_time", SqlDbType.Float, 8).Value = Me.TotalPourTime
            oCmd.Parameters.Add("@pouring_start_time", SqlDbType.Float, 8).Value = Me.Pouring_start_time
            oCmd.Parameters.Add("@plunser_pressure", SqlDbType.Float, 8).Value = Me.Plunser_pressure
            Dim dt1 As DataTable
            dt1 = RWF.tables.getWheelsCopesDragsUsed(Me.Number)
            oCmd.Parameters.Add("@wheels_cast_cope", SqlDbType.Int, 4).Value = IIf(IsDBNull(dt1.Rows(0)("CopesUsed")), "0", dt1.Rows(0)("CopesUsed"))
            oCmd.Parameters.Add("@wheels_cast_drag", SqlDbType.Int, 4).Value = IIf(IsDBNull(dt1.Rows(0)("DragsUsed")), "0", dt1.Rows(0)("DragsUsed"))
            oCmd.Parameters.Add("@total_wheels_poured", SqlDbType.Int, 4).Value = IIf(IsDBNull(dt1.Rows(0)("WhlsCast")), "0", dt1.Rows(0)("WhlsCast"))
            dt1 = Nothing

            oCmd.Parameters.Add("@cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output
            oCmd.CommandText = " select @cnt = count(*) from mm_pre_pouring where heat_number = @heat_number"
            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.Transaction = oCmd.Connection.BeginTransaction
                oCmd.ExecuteScalar()
                If IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value) = 0 Then
                    oCmd.CommandText = " insert into mm_pre_pouring ( cast_date , heat_number , furnace_code , " &
                        " operator_mould , shift_supervisor , jmp_cover1 , ladle_lift_time , tube1_immersion1_time , " &
                        " tube1_immersion1_temperature , tube1_immersion2_time , tube1_immersion2_temperature , " &
                        " tube1_immersion3_time , tube1_immersion3_temperature , aluminium_stars , " &
                        " aluminium_dip_temperature , slag_condition , stop_support ,  " &
                        " riser_weight , tube1_mfg , tube2_mfg , tube3_mfg , tube1_life , tube2_life , tube3_life , " &
                        " pouring_tank_number , ladle_metal_level , ladle_insl , tube1_in_time , tube2_in_time , " &
                        " tube3_in_time , tube1_out_time , tube2_out_time , tube3_out_time , ladle_in_time , " &
                        " ladle_temp , tube_no_1 , tube_no_2 , tube_no_3 , metal_recieved , tube_no_1_con , tube_no_2_con , tube_no_3_con ) " &
                        " values ( @cast_date , @heat_number , @furnace_code , @operator_mould , @shift_supervisor , " &
                        " @jmp_cover1 , @ladle_lift_time , @tube1_immersion1_time , @tube1_immersion1_temperature , " &
                        " @tube1_immersion2_time, @tube1_immersion2_temperature ,  @tube1_immersion3_time , " &
                        " @tube1_immersion3_temperature , @aluminium_stars , @aluminium_dip_temperature , " &
                        " @slag_condition , @stop_support , @riser_weight , @tube1_mfg , @tube2_mfg , @tube3_mfg ," &
                        " @tube1_life , @tube2_life , @tube3_life , @pouring_tank_number , @ladle_metal_level , " &
                        " @ladle_insl , @tube1_in_time , @tube2_in_time , @tube3_in_time , @tube1_out_time , " &
                        " @tube2_out_time , @tube3_out_time , @ladle_in_time , @ladle_temp , @tube_no_1 , @tube_no_2 , @tube_no_3  , @metal_recieved , " &
                        " @tube_no_1_con , @tube_no_2_con , @tube_no_3_con ) "
                Else
                    oCmd.CommandText = " update mm_pre_pouring set cast_date = @cast_date , furnace_code = @furnace_code , operator_mould = @operator_mould , " &
                        " shift_supervisor = @shift_supervisor , jmp_cover1 = @jmp_cover1 , ladle_lift_time = @ladle_lift_time ," &
                        " tube1_immersion1_time = @tube1_immersion1_time , tube1_immersion1_temperature = @tube1_immersion1_temperature , " &
                        " tube1_immersion2_time = @tube1_immersion2_time , tube1_immersion2_temperature = @tube1_immersion2_temperature ," &
                        " tube1_immersion3_time = @tube1_immersion3_time , tube1_immersion3_temperature = @tube1_immersion3_temperature , " &
                        " aluminium_stars = @aluminium_stars , aluminium_dip_temperature = @aluminium_dip_temperature , " &
                        " slag_condition = @slag_condition , stop_support = @stop_support , riser_weight = @riser_weight , " &
                        " tube1_mfg = @tube1_mfg , tube2_mfg = @tube2_mfg , tube3_mfg = @tube3_mfg ," &
                        " tube1_life = @tube1_life , tube2_life = @tube2_life , tube3_life = @tube3_life ," &
                        " pouring_tank_number = @pouring_tank_number , ladle_metal_level = @ladle_metal_level , " &
                        " ladle_insl = @ladle_insl , tube1_in_time = @tube1_in_time , tube2_in_time = @tube2_in_time ," &
                        " tube3_in_time = @tube3_in_time , tube1_out_time = @tube1_out_time , tube2_out_time = @tube2_out_time , " &
                        " tube3_out_time = @tube3_out_time , ladle_in_time = @ladle_in_time , ladle_temp = @ladle_temp , " &
                        " tube_no_1 = @tube_no_1 , tube_no_2 = @tube_no_2 , tube_no_3 = @tube_no_3 , metal_recieved = @metal_recieved , " &
                        " tube_no_1_con = @tube_no_1_con , tube_no_2_con = @tube_no_2_con , tube_no_3_con = @tube_no_3_con " &
                        " where heat_number = @heat_number "
                End If

                If oCmd.ExecuteNonQuery = 1 Then
                    oCmd.Parameters("@cnt").Value = 0
                    oCmd.CommandText = " select @cnt = count(*) from mm_post_pouring where heat_number = @heat_number"
                    oCmd.ExecuteScalar()
                    If IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value) = 0 Then
                        oCmd.CommandText = " insert into mm_post_pouring ( heat_number ,  dome_disc_used ,  end_temperature ,  drain_mm ,  d13_temperature , " &
                            " end_time , d14_temperature ,  c20_temperature ,  c21_temperature ,  cope_spray_r ,  cope_spray_p ,  " &
                            " cope_spray_h ,  cope_spray_b ,  drag_spray_r ,  drag_spray_h ,  drag_spray_p ,  drag_spray_b ,  " &
                            " drag_spray_starttime ,  drag_spray_endtime ,  cope_drag_spray_sttime ,  cope_drag_spray_endtime , " &
                            " spru_wash_sttime ,  spru_wash_endtime ,  hub_cut_sttime ,  hub_cut_endtime ,  core_bak_sttime ,  " &
                            " core_bak_endtime ,  tube_condition ,  remarks ,  sprue_ampere ,  spure_pressure , total_pour_time , " &
                            " wheels_cast_cope , wheels_cast_drag , total_wheels_poured ) values ( " &
                            " @heat_number ,  @dome_disc_used ,  @end_temperature ,  @drain_mm ,  @d13_temperature ," &
                            " @EndTime , @d14_temperature ,  @c20_temperature ,  @c21_temperature ,  @cope_spray_r ,  @cope_spray_p , " &
                            " @cope_spray_h ,  @cope_spray_b ,  @drag_spray_r ,  @drag_spray_h ,  @drag_spray_p ,  @drag_spray_b ,  " &
                            " @drag_spray_starttime ,  @drag_spray_endtime ,  @cope_drag_spray_sttime ,  @cope_drag_spray_endtime ," &
                            " @spru_wash_sttime ,  @spru_wash_endtime ,  @hub_cut_sttime ,  @hub_cut_endtime ,  @core_bak_sttime ,  " &
                            " @core_bak_endtime ,  @tube_condition ,  @remarks ,  @sprue_ampere ,  @spure_pressure , " &
                            " @total_pour_time , @wheels_cast_cope , @wheels_cast_drag , @total_wheels_poured ) "
                    Else
                        oCmd.CommandText = " update mm_post_pouring set  dome_disc_used = @dome_disc_used ,  end_temperature = @end_temperature , " &
                            " end_time = @EndTime , drain_mm = @drain_mm ,  d13_temperature = @d13_temperature , " &
                            " d14_temperature = @d14_temperature ,  c20_temperature = @c20_temperature ,  " &
                            " c21_temperature = @c21_temperature ,  cope_spray_r = @cope_spray_r ,  cope_spray_p = @cope_spray_p ,  " &
                            " cope_spray_h = @cope_spray_h ,  cope_spray_b = @cope_spray_b ,  drag_spray_r = @drag_spray_r , " &
                            " drag_spray_h = @drag_spray_h ,  drag_spray_p = @drag_spray_p ,  drag_spray_b = @drag_spray_b ,  " &
                            " drag_spray_starttime = @drag_spray_starttime ,  drag_spray_endtime = @drag_spray_endtime , " &
                            " cope_drag_spray_sttime = @cope_drag_spray_sttime ,  cope_drag_spray_endtime = @cope_drag_spray_endtime , " &
                            " spru_wash_sttime = @spru_wash_sttime ,  spru_wash_endtime = @spru_wash_endtime ,  " &
                            " hub_cut_sttime = @hub_cut_sttime ,  hub_cut_endtime = @hub_cut_endtime ,  core_bak_sttime = @core_bak_sttime ,  " &
                            " core_bak_endtime = @core_bak_endtime ,  tube_condition = @tube_condition ,  remarks = @remarks , " &
                            " sprue_ampere = @sprue_ampere ,  spure_pressure =  @spure_pressure , " &
                            " total_pour_time = @total_pour_time , wheels_cast_cope = @wheels_cast_cope , " &
                            " wheels_cast_drag = @wheels_cast_drag , total_wheels_poured = @total_wheels_poured where heat_number = @heat_number "
                    End If
                    If oCmd.ExecuteNonQuery = 1 Then done = True
                    oCmd.Parameters("@cnt").Value = 0
                    oCmd.CommandText = " select @cnt = count(*) from mm_pouring_group where heat_number = @heat_number"
                    oCmd.ExecuteScalar()
                    If IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value) = 0 Then
                        oCmd.CommandText = " insert into mm_pouring_group ( heat_number , ShiftGroup ) values ( @heat_number , @ShiftGroup ) "
                    Else
                        oCmd.CommandText = " update mm_pouring_group set ShiftGroup = @ShiftGroup where heat_number = @heat_number "
                    End If
                    oCmd.ExecuteNonQuery()
                End If
            Catch exp As Exception
                sMessage = exp.Message
            Finally
                If done Then
                    oCmd.Transaction.Commit()
                Else
                    oCmd.Transaction.Rollback()
                End If
                oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
            End Try
            Return done
        End Function


#End Region
    End Class
    Friend Class Pouring
        Inherits RWF.Wheel
#Region " Fields"
        Private sPourStatus, sRemarks, sMessage, sPreCopeNo, sPreDragNo As String
        Private dateMeltDate, dateMouldDate As Date
        Private intPreEngraved As Integer
        Private decControledRate, decFastRate As Decimal



#End Region
#Region " Property"



        Property ControledRate() As Decimal
            Get
                Return decControledRate
            End Get
            Set(ByVal Value As Decimal)
                decControledRate = Value
            End Set
        End Property



        Property FastRate() As Decimal
            Get
                Return decFastRate
            End Get
            Set(ByVal Value As Decimal)
                decFastRate = Value
            End Set
        End Property
        Property PreEngraved() As Integer
            Get
                Return intPreEngraved
            End Get
            Set(ByVal Value As Integer)
                intPreEngraved = Value
            End Set
        End Property
        Property PreDragNo() As String
            Get
                Return sPreDragNo
            End Get
            Set(ByVal Value As String)
                sPreDragNo = Value
            End Set
        End Property
        Property PreCopeNo() As String
            Get
                Return sPreCopeNo
            End Get
            Set(ByVal Value As String)
                sPreCopeNo = Value
            End Set
        End Property
        Property MouldDate() As Date
            Get
                Return dateMouldDate
            End Get
            Set(ByVal Value As Date)
                dateMouldDate = Value
            End Set
        End Property
        Property MeltDate() As Date
            Get
                Return dateMeltDate
            End Get
            Set(ByVal Value As Date)
                dateMeltDate = Value
            End Set
        End Property
        ReadOnly Property Message() As String
            Get
                Return sMessage
            End Get
        End Property
        Property Remarks() As String
            Get
                Return sRemarks
            End Get
            Set(ByVal Value As String)
                sRemarks = Value
            End Set
        End Property
        Property PourStatus() As String
            Get
                Return sPourStatus
            End Get
            Set(ByVal Value As String)
                sPourStatus = Value
            End Set
        End Property
#End Region
#Region " Methods"
        Private Sub iniVals()
            sPreDragNo = ""
            sPreCopeNo = ""
            sMessage = ""
            sRemarks = ""
            sPourStatus = ""
            intPreEngraved = 0
            decControledRate = 0.0
            decFastRate = 0.0
        End Sub
        Public Sub New()
            iniVals()
        End Sub
        Public Function savePourDetails(ByVal SlNo As Long) As Boolean
            Dim done As Boolean
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            oCmd.Parameters.Add("@heat_number", SqlDbType.Int, 4).Value = Me.Heat
            oCmd.Parameters.Add("@workorder_number", SqlDbType.VarChar, 10).Value = Me.WorkOrder
            oCmd.Parameters.Add("@pour_order", SqlDbType.Int, 4).Value = Me.PourOrder
            oCmd.Parameters.Add("@pour_time", SqlDbType.DateTime, 8).Value = Me.PourTime
            oCmd.Parameters.Add("@cope_number", SqlDbType.VarChar, 10).Value = Me.CopeNumber
            oCmd.Parameters.Add("@cope_used", SqlDbType.Int, 4).Value = Me.CopeLife
            oCmd.Parameters.Add("@drag_number", SqlDbType.VarChar, 10).Value = Me.DragNumber
            oCmd.Parameters.Add("@engraved_number", SqlDbType.Int, 4).Value = Me.Wheel
            oCmd.Parameters.Add("@drag_used", SqlDbType.Int, 4).Value = Me.DragLife
            oCmd.Parameters.Add("@ingate_used", SqlDbType.Int, 4).Value = Me.IngLife
            oCmd.Parameters.Add("@split_time", SqlDbType.DateTime, 8).Value = Me.SplitTime
            oCmd.Parameters.Add("@whether_f_c", SqlDbType.VarChar, 2).Value = Me.PourRate
            oCmd.Parameters.Add("@rejection_code", SqlDbType.VarChar, 50).Value = sPourStatus
            oCmd.Parameters.Add("@remarks", SqlDbType.VarChar, 30).Value = sRemarks
            oCmd.Parameters.Add("@whl_type", SqlDbType.VarChar, 50).Value = Me.WhlType

            oCmd.Parameters.Add("@wheel_number", SqlDbType.Int, 4).Value = Me.Wheel
            oCmd.Parameters.Add("@Workorder_melt_mould", SqlDbType.VarChar, 10).Value = Me.WorkOrder
            oCmd.Parameters.Add("@date_melt", SqlDbType.SmallDateTime, 4).Value = dateMeltDate
            oCmd.Parameters.Add("@date_mould", SqlDbType.SmallDateTime, 4).Value = dateMouldDate
            oCmd.Parameters.Add("@Status", SqlDbType.VarChar, 50).Value = sPourStatus
            oCmd.Parameters.Add("@description", SqlDbType.VarChar, 50).Value = Me.WhlType
            oCmd.Parameters.Add("@SlNo", SqlDbType.BigInt, 8).Value = SlNo

            oCmd.Parameters.Add("@PreCopeNo", SqlDbType.VarChar, 10).Value = sPreCopeNo
            oCmd.Parameters.Add("@PreDragNo", SqlDbType.VarChar, 10).Value = sPreDragNo
            oCmd.Parameters.Add("@PreEngraved", SqlDbType.Int, 4).Value = intPreEngraved

            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.Transaction = oCmd.Connection.BeginTransaction
                If SlNo = 0 Then
                    oCmd.CommandText = " INSERT INTO mm_wheel (wheel_number, workOrder_melt_mould, date_melt, date_mould, pour_order, cope_number, drag_number, status, description, location, heat_number) " &
                        " Values ( @wheel_number, @Workorder_melt_mould, @date_melt, @date_mould, @pour_order, @cope_number, @drag_number, @Status, @description, 'MOPO', @heat_number)"
                    If oCmd.ExecuteNonQuery > 0 Then
                        oCmd.CommandText = "INSERT INTO mm_pouring (heat_number, workorder_number, pouring_order, pour_time, cope_number, cope_used, drag_number, engraved_number, drag_used, ingate_used, split_time, whether_f_c, rejection_code, remarks, wheel_type) " &
                                        " Values( @heat_number, @workorder_number, @pour_order, @pour_time, @cope_number, @cope_used, @drag_number, @engraved_number, @drag_used, @ingate_used, @split_time, @whether_f_c, @rejection_code, @remarks, @whl_type )"
                        If oCmd.ExecuteNonQuery > 0 Then
                            done = True
                            If Me.sPourStatus <> "6&7" OrElse Me.sPourStatus <> "6" Then
                                done = False
                                oCmd.CommandText = " UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf >= 0 then cpdglf else 0 end + 1 WHERE mld_no = @cope_number  and mld_typ = 'C'"
                                If oCmd.ExecuteNonQuery = 1 Then
                                    done = True
                                End If
                            End If
                            If Me.sPourStatus <> "6&7" OrElse Me.sPourStatus <> "7" Then
                                done = False
                                oCmd.CommandText = "UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf >= 0 then cpdglf else 0 end + 1, inglif = case when inglif >= 0 then inglif else 0 end  + 1 WHERE mld_no = @drag_number and mld_typ = 'D'"
                                If oCmd.ExecuteNonQuery > 0 Then
                                    done = True
                                End If
                            End If
                        End If
                    End If
                Else
                    oCmd.CommandText = "Update mm_pouring set workorder_number = @workorder_number, pouring_order = @pour_order, pour_time = @pour_time, cope_number = @cope_number, cope_used = @cope_used, " &
                        " drag_number = @drag_number, engraved_number = @engraved_number, drag_used = @drag_used, ingate_used = @ingate_used, split_time = @split_time, whether_f_c = @whether_f_c, rejection_code = @rejection_code, " &
                        " remarks = @remarks, wheel_type = @whl_type WHERE slno = @SlNo and heat_number = @heat_number "
                    If oCmd.ExecuteNonQuery > 0 Then
                        oCmd.CommandText = "UPDATE mm_wheel SET wheel_number = @wheel_number, workOrder_melt_mould = @Workorder_melt_mould, date_melt = @date_melt, date_mould = @date_mould, pour_order = @pour_order," &
                        " cope_number =  @cope_number , drag_number = @drag_number, status = @Status, description = @whl_type WHERE heat_number = @heat_number and wheel_number = @PreEngraved"
                        If oCmd.ExecuteNonQuery > 0 Then done = True
                    End If
                End If
                If sPreCopeNo <> Me.CopeNumber Then
                    If sPreCopeNo <> "" Then
                        done = False
                        oCmd.CommandText = "UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf > 0 then cpdglf else 1 end - 1 WHERE mld_no = '" & sPreCopeNo.Trim & "' and mld_typ = 'C'"
                        If oCmd.ExecuteNonQuery > 0 Then
                            If Me.CopeLife <> 0 Then
                                oCmd.CommandText = "UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf >= 0 then cpdglf else 0 end  + 1 WHERE mld_no = @cope_number and mld_typ = 'C'"
                                If oCmd.ExecuteNonQuery > 0 Then
                                    done = True
                                End If
                            Else
                                done = True
                            End If
                        End If
                    Else
                        done = True
                    End If
                Else
                    If Me.sPourStatus = "6&7" OrElse Me.sPourStatus = "6" Then
                        done = False
                        oCmd.CommandText = " UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf >= 0 then cpdglf else 0 end - 1 WHERE mld_no = @cope_number  and mld_typ = 'C'"
                        If oCmd.ExecuteNonQuery = 1 Then
                            done = True
                        End If
                    End If
                End If
                If sPreDragNo <> Me.DragNumber Then
                    If sPreDragNo <> "" Then
                        done = False
                        oCmd.CommandText = "UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf > 0 then cpdglf else 1 end  - 1, inglif = case when inglif > 0 then inglif else 1 end  - 1 WHERE mld_no = '" & sPreDragNo.Trim & "' and mld_typ = 'D'"
                        If oCmd.ExecuteNonQuery = 1 Then
                            ' moved here on 14-3-08 to avoid incrementing in edit from outside if scope
                            If Me.DragLife <> 0 Then
                                ' strSql = "UPDATE mm_mmmdmt_dump SET cpdglf = cpdglf + 1, inglif = inglif + 1 WHERE mld_no = '" & txtDragNo.Text.Trim & "' and mld_typ = 'D'"
                                oCmd.CommandText = "UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf >= 0 then cpdglf else 0 end  + 1, inglif = case when inglif >=0 then inglif else 0 end + 1 WHERE mld_no = @drag_number and mld_typ = 'D'"
                                If oCmd.ExecuteNonQuery = 1 Then
                                    done = True
                                End If
                            Else
                                done = True
                            End If
                        End If
                    Else
                        done = True
                    End If
                Else
                    If Me.sPourStatus = "6&7" OrElse Me.sPourStatus = "7" Then
                        done = False
                        oCmd.CommandText = "UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf >= 0 then cpdglf else 0 end - 1, inglif = case when inglif >= 0 then inglif else 0 end  - 1 WHERE mld_no = @drag_number and mld_typ = 'D'"
                        If oCmd.ExecuteNonQuery > 0 Then
                            done = True
                        End If
                    End If
                End If
            Catch exp As Exception
                sMessage = exp.Message
            Finally
                If done Then
                    oCmd.Transaction.Commit()
                Else
                    oCmd.Transaction.Rollback()
                End If
                oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
            End Try
            Return done
        End Function

        Public Function savePourDetail(ByVal SlNo As Long) As Boolean
            Dim done As Boolean
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            oCmd.Parameters.Add("@heat_number", SqlDbType.Int, 4).Value = Me.Heat
            oCmd.Parameters.Add("@workorder_number", SqlDbType.VarChar, 10).Value = Me.WorkOrder
            oCmd.Parameters.Add("@pour_order", SqlDbType.Int, 4).Value = Me.PourOrder
            oCmd.Parameters.Add("@pour_time", SqlDbType.DateTime, 8).Value = Me.PourTime
            oCmd.Parameters.Add("@cope_number", SqlDbType.VarChar, 10).Value = Me.CopeNumber
            oCmd.Parameters.Add("@cope_used", SqlDbType.Int, 4).Value = Me.CopeLife
            oCmd.Parameters.Add("@drag_number", SqlDbType.VarChar, 10).Value = Me.DragNumber
            oCmd.Parameters.Add("@engraved_number", SqlDbType.Int, 4).Value = Me.Wheel
            oCmd.Parameters.Add("@drag_used", SqlDbType.Int, 4).Value = Me.DragLife
            oCmd.Parameters.Add("@ingate_used", SqlDbType.Int, 4).Value = Me.IngLife
            oCmd.Parameters.Add("@split_time", SqlDbType.DateTime, 8).Value = Me.SplitTime
            oCmd.Parameters.Add("@whether_f_c", SqlDbType.VarChar, 2).Value = Me.PourRate
            oCmd.Parameters.Add("@rejection_code", SqlDbType.VarChar, 50).Value = sPourStatus
            oCmd.Parameters.Add("@remarks", SqlDbType.VarChar, 30).Value = sRemarks
            oCmd.Parameters.Add("@whl_type", SqlDbType.VarChar, 50).Value = Me.WhlType

            oCmd.Parameters.Add("@wheel_number", SqlDbType.Int, 4).Value = Me.Wheel
            oCmd.Parameters.Add("@Workorder_melt_mould", SqlDbType.VarChar, 10).Value = Me.WorkOrder
            oCmd.Parameters.Add("@date_melt", SqlDbType.SmallDateTime, 4).Value = dateMeltDate
            oCmd.Parameters.Add("@date_mould", SqlDbType.SmallDateTime, 4).Value = dateMouldDate
            oCmd.Parameters.Add("@Status", SqlDbType.VarChar, 50).Value = sPourStatus
            oCmd.Parameters.Add("@description", SqlDbType.VarChar, 50).Value = Me.WhlType
            oCmd.Parameters.Add("@SlNo", SqlDbType.BigInt, 8).Value = SlNo

            oCmd.Parameters.Add("@PreCopeNo", SqlDbType.VarChar, 10).Value = sPreCopeNo
            oCmd.Parameters.Add("@PreDragNo", SqlDbType.VarChar, 10).Value = sPreDragNo
            oCmd.Parameters.Add("@PreEngraved", SqlDbType.Int, 4).Value = intPreEngraved



            oCmd.Parameters.Add("@CHOTMP", SqlDbType.Int, 4).Value = Me.CHOTMP
            oCmd.Parameters.Add("@BCTMP", SqlDbType.Int, 4).Value = Me.BCTMP
            oCmd.Parameters.Add("@SCTMP", SqlDbType.Int, 4).Value = Me.SCTMP
            oCmd.Parameters.Add("@DHOTMP", SqlDbType.Int, 4).Value = Me.DHOTMP
            oCmd.Parameters.Add("@SDTMP", SqlDbType.Int, 4).Value = Me.SDTMP
            oCmd.Parameters.Add("@CHONO", SqlDbType.VarChar, 10).Value = Me.CHONO
            oCmd.Parameters.Add("@DHONO", SqlDbType.VarChar, 10).Value = Me.DHONO

            'oCmd.Parameters.Add("@TBINT", SqlDbType.DateTime, 8).Value = Me.TBINT
            'oCmd.Parameters.Add("@TBOUTT", SqlDbType.DateTime, 8).Value = Me.TBOUTT
            oCmd.Parameters.Add("@LIM", SqlDbType.Int, 4).Value = Me.LIM
            oCmd.Parameters.Add("@OPERATOR1", SqlDbType.VarChar, 20).Value = Me.OPERATOR1
            oCmd.Parameters.Add("@SIC", SqlDbType.VarChar, 20).Value = Me.SIC
            oCmd.Parameters.Add("@SHIFTID", SqlDbType.VarChar, 20).Value = Me.SHIFTID



            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.Transaction = oCmd.Connection.BeginTransaction
                If SlNo = 0 Then
                    oCmd.CommandText = " INSERT INTO mm_wheel (wheel_number, workOrder_melt_mould, date_melt, date_mould, pour_order, cope_number, drag_number, status, description, location, heat_number) " &
                        " Values ( @wheel_number, @Workorder_melt_mould, @date_melt, @date_mould, @pour_order, @cope_number, @drag_number, @Status, @description, 'MOPO', @heat_number )"
                    If oCmd.ExecuteNonQuery > 0 Then
                        oCmd.CommandText = "INSERT INTO mm_pouring (heat_number, workorder_number, pouring_order, pour_time, cope_number, cope_used, drag_number, engraved_number, drag_used, ingate_used, split_time, whether_f_c, rejection_code, remarks, wheel_type,CHOTMP,BCTMP,SCTMP,DHOTMP,SDTMP,CHONO,DHONO,TBINT ,TBOUTT,LIM ,OPERATOR ,SIC,SHIFTID ) " &
                                        " Values( @heat_number, @workorder_number, @pour_order, @pour_time, @cope_number, @cope_used, @drag_number, @engraved_number, @drag_used, @ingate_used, @split_time, @whether_f_c, @rejection_code, @remarks, @whl_type ,@CHOTMP,@BCTMP,@SCTMP,@DHOTMP,@SDTMP,@CHONO,@DHONO,getdate() ,getdate(),@LIM ,@OPERATOR1 ,@SIC,@SHIFTID )"
                        If oCmd.ExecuteNonQuery > 0 Then
                            done = True
                            If Me.sPourStatus <> "6&7" OrElse Me.sPourStatus <> "6" Then
                                done = False
                                oCmd.CommandText = " UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf >= 0 then cpdglf else 0 end + 1 WHERE mld_no = @cope_number  and mld_typ = 'C'"
                                If oCmd.ExecuteNonQuery = 1 Then
                                    done = True
                                End If
                            End If
                            If Me.sPourStatus <> "6&7" OrElse Me.sPourStatus <> "7" Then
                                done = False
                                oCmd.CommandText = "UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf >= 0 then cpdglf else 0 end + 1, inglif = case when inglif >= 0 then inglif else 0 end  + 1 WHERE mld_no = @drag_number and mld_typ = 'D'"
                                If oCmd.ExecuteNonQuery > 0 Then
                                    done = True
                                End If
                            End If
                        End If
                    End If
                Else
                    oCmd.CommandText = "Update mm_pouring set workorder_number = @workorder_number, pouring_order = @pour_order, pour_time = @pour_time, cope_number = @cope_number, cope_used = @cope_used, " &
                        " drag_number = @drag_number, engraved_number = @engraved_number, drag_used = @drag_used, ingate_used = @ingate_used, split_time = @split_time, whether_f_c = @whether_f_c, rejection_code = @rejection_code, " &
                        " remarks = @remarks, wheel_type = @whl_type,CHOTMP=@CHOTMP,BCTMP=@BCTMP,SCTMP=@SCTMP,DHOTMP=@DHOTMP,SDTMP=@SDTMP,CHONO=@CHONO,DHONO=@DHONO,TBINT=getdate() ,TBOUTT=getdate(),LIM=@LIM ,OPERATOR= @OPERATOR1,SIC=@SIC,SHIFTID=@SHIFTID WHERE slno = @SlNo and heat_number = @heat_number "
                    If oCmd.ExecuteNonQuery > 0 Then
                        oCmd.CommandText = "UPDATE mm_wheel SET wheel_number = @wheel_number, workOrder_melt_mould = @Workorder_melt_mould, date_melt = @date_melt, date_mould = @date_mould, pour_order = @pour_order," &
                        " cope_number =  @cope_number , drag_number = @drag_number, status = @Status, description = @whl_type WHERE heat_number = @heat_number and wheel_number = @PreEngraved"
                        If oCmd.ExecuteNonQuery > 0 Then done = True
                    End If
                End If
                If sPreCopeNo <> Me.CopeNumber Then
                    If sPreCopeNo <> "" Then
                        done = False
                        oCmd.CommandText = "UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf > 0 then cpdglf else 1 end - 1 WHERE mld_no = '" & sPreCopeNo.Trim & "' and mld_typ = 'C'"
                        If oCmd.ExecuteNonQuery > 0 Then
                            If Me.CopeLife <> 0 Then
                                oCmd.CommandText = "UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf >= 0 then cpdglf else 0 end  + 1 WHERE mld_no = @cope_number and mld_typ = 'C'"
                                If oCmd.ExecuteNonQuery > 0 Then
                                    done = True
                                End If
                            Else
                                done = True
                            End If
                        End If
                    Else
                        done = True
                    End If
                Else
                    If Me.sPourStatus = "6&7" OrElse Me.sPourStatus = "6" Then
                        done = False
                        oCmd.CommandText = " UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf >= 0 then cpdglf else 0 end - 1 WHERE mld_no = @cope_number  and mld_typ = 'C'"
                        If oCmd.ExecuteNonQuery = 1 Then
                            done = True
                        End If
                    End If
                End If
                If sPreDragNo <> Me.DragNumber Then
                    If sPreDragNo <> "" Then
                        done = False
                        oCmd.CommandText = "UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf > 0 then cpdglf else 1 end  - 1, inglif = case when inglif > 0 then inglif else 1 end  - 1 WHERE mld_no = '" & sPreDragNo.Trim & "' and mld_typ = 'D'"
                        If oCmd.ExecuteNonQuery = 1 Then
                            ' moved here on 14-3-08 to avoid incrementing in edit from outside if scope
                            If Me.DragLife <> 0 Then
                                ' strSql = "UPDATE mm_mmmdmt_dump SET cpdglf = cpdglf + 1, inglif = inglif + 1 WHERE mld_no = '" & txtDragNo.Text.Trim & "' and mld_typ = 'D'"
                                oCmd.CommandText = "UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf >= 0 then cpdglf else 0 end  + 1, inglif = case when inglif >=0 then inglif else 0 end + 1 WHERE mld_no = @drag_number and mld_typ = 'D'"
                                If oCmd.ExecuteNonQuery = 1 Then
                                    done = True
                                End If
                            Else
                                done = True
                            End If
                        End If
                    Else
                        done = True
                    End If
                Else
                    If Me.sPourStatus = "6&7" OrElse Me.sPourStatus = "7" Then
                        done = False
                        oCmd.CommandText = "UPDATE mm_mmmdmt_dump SET cpdglf = case when cpdglf >= 0 then cpdglf else 0 end - 1, inglif = case when inglif >= 0 then inglif else 0 end  - 1 WHERE mld_no = @drag_number and mld_typ = 'D'"
                        If oCmd.ExecuteNonQuery > 0 Then
                            done = True
                        End If
                    End If
                End If
            Catch exp As Exception
                sMessage = exp.Message
            Finally
                If done Then
                    oCmd.Transaction.Commit()
                Else
                    oCmd.Transaction.Rollback()
                End If
                oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
            End Try
            Return done
        End Function

        Public Sub New(ByVal HeatNumber As Long, ByVal PourStartTime As DateTime, ByVal PourStartTemp As Integer)
            Dim Done As Boolean
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            Try
                oCmd.Parameters.Add("@HeatNumber", SqlDbType.BigInt, 8).Value = HeatNumber
                oCmd.Parameters.Add("@PourStartTime", SqlDbType.DateTime, 8).Value = PourStartTime
                oCmd.Parameters.Add("@PourStartTemp", SqlDbType.Int, 4).Value = PourStartTemp
                oCmd.Parameters.Add("@Cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.Transaction = oCmd.Connection.BeginTransaction
                oCmd.CommandText = " select @Cnt = count(*) from mm_pouring_StartTime where heat_number = @HeatNumber "
                oCmd.ExecuteScalar()
                If IIf(IsDBNull(oCmd.Parameters("@Cnt").Value), 0, oCmd.Parameters("@Cnt").Value) = 0 Then
                    oCmd.CommandText = "insert into mm_pouring_StartTime " & _
                                                    " ( heat_number , PourStartTime  , PourStartTemp ) " & _
                                                    " values ( @HeatNumber , @PourStartTime , @PourStartTemp  ) "
                Else
                    oCmd.CommandText = " Update mm_pouring_StartTime " & _
                        " set PourStartTemp = @PourStartTemp  , PourStartTime = @PourStartTime " & _
                        " where heat_number = @HeatNumber "
                End If
                If oCmd.ExecuteNonQuery = 1 Then
                    Done = True
                Else
                    Throw New Exception(" updation of Pour StartTime data failed !")
                End If
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If Not IsNothing(oCmd) Then
                    If Done Then
                        oCmd.Transaction.Commit()
                    Else
                        oCmd.Transaction.Rollback()
                    End If
                    If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                    oCmd.Dispose()
                    oCmd = Nothing
                End If
            End Try
        End Sub
        Public Sub New(ByVal HeatNumber As Long, ByVal WheelNumber As Long, ByVal CRate As Decimal, ByVal FRate As Decimal)
            Dim Done As Boolean
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.Parameters.Add("@heat_number", SqlDbType.BigInt, 8).Value = HeatNumber
                oCmd.Parameters.Add("@wheel_number", SqlDbType.BigInt, 8).Value = WheelNumber
                oCmd.Parameters.Add("@ControledRate", SqlDbType.Decimal, 5, 2).Value = CRate
                oCmd.Parameters.Add("@FastRate", SqlDbType.Decimal, 5, 2).Value = FRate
                oCmd.Parameters.Add("@cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output
                oCmd.CommandText = "select @cnt = count(*)  from mm_pouring_rate where heat_number = @heat_number  and wheel_number = @wheel_number"
                oCmd.ExecuteScalar()
                If Trim(IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value)) = 0 Then
                    oCmd.CommandText = "insert into mm_pouring_rate ( heat_number , wheel_number , ControledRate , FastRate ) values ( @heat_number, @wheel_number, @ControledRate , @FastRate  ) "
                Else
                    oCmd.CommandText = "update mm_pouring_rate set ControledRate = @ControledRate , FastRate = @FastRate  where heat_number = @heat_number and wheel_number = @wheel_number "
                End If
                If oCmd.ExecuteNonQuery = 1 Then Done = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                oCmd.Connection.Close()
                oCmd = Nothing
            End Try
        End Sub
        Public Shared Function PouringStartTime(ByVal HeatNumber As Long) As DataTable
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Dim ds As New DataSet()
            Try
                '  da.SelectCommand.CommandText = " select PourStartTime , PourStartTemp from mm_pouring_StartTime  " &
                '   " where heat_number = @HeatNumber "
                da.SelectCommand.CommandText = " select pouring_start_time  from mm_pre_pouring " &
                   " where heat_number = @HeatNumber "
                da.SelectCommand.Parameters.Add("@HeatNumber", SqlDbType.BigInt, 8).Value = HeatNumber
                da.Fill(ds)
                PouringStartTime = ds.Tables(0).Copy
            Catch exp As Exception
                PouringStartTime = Nothing
                Throw New Exception(" Retrival error" & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function PouringRate(ByVal HeatNumber As Long, ByVal WheelNumber As Long) As DataTable
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Dim ds As New DataSet()
            Try
                da.SelectCommand.Connection = New SqlClient.SqlConnection(ConfigurationSettings.AppSettings("con"))
                da.SelectCommand.CommandText = " select ControledRate , FastRate  from mm_pouring_rate " & _
                    " where heat_number = @HeatNumber and wheel_number = @WheelNumber "
                da.SelectCommand.Parameters.Add("@HeatNumber", SqlDbType.BigInt, 8).Value = HeatNumber
                da.SelectCommand.Parameters.Add("@WheelNumber", SqlDbType.BigInt, 8).Value = WheelNumber
                da.Fill(ds)
                PouringRate = ds.Tables(0).Copy
            Catch exp As Exception
                PouringRate = Nothing
                Throw New Exception(" Retrival error" & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
#End Region
    End Class
    Public Class MLDING
        Public Shared Function GetNFHeatWheels(ByVal HeatNo As Long) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.Parameters.Add("@HeatNo", SqlDbType.BigInt, 8).Value = HeatNo
                da.SelectCommand.CommandText = " select row_number() over ( order by TimeIn ,TimeOut ) Sl , " &
                    " convert(varchar(10),TimeInDate,103) ChargeDt , TimeInSh Sh , WheelType , HeatNo , " &
                    " WheelNo , SIC , OP1 , OP2 , PedNo , PedPosition Pos , " &
                    " convert(varchar(10),TimeIn,103) DateIn , convert(varchar(5),TimeIn,108) TimeIn , " &
                    " convert(varchar(10),TimeOut,103) DateOut , convert(varchar(5),TimeOut,108) TimeOut , " &
                    " Quencher , Remarks , SlNo" &
                    " from mm_vw_WheelNormalisingDetails where HeatNo = @HeatNo"
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function

        Public Shared Function GetMasterBatchData(ByVal BNo As Integer) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select Batch_No. Batch_SrNo, Heat_No, Wheel_Number from mm_wheel_heat_batch_details where Batch_No= @BNo "
                da.SelectCommand.Parameters.Add("@BNo", SqlDbType.Int, 4).Value = BNo
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function

        Public Shared Function GetNFScore(ByVal TimeInDate As Date, ByVal TimeInSh As String) As DataSet
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.Parameters.Add("@TimeInDate", SqlDbType.SmallDateTime, 4).Value = TimeInDate
                da.SelectCommand.Parameters.Add("@TimeInSh", SqlDbType.VarChar, 1).Value = TimeInSh
                da.SelectCommand.CommandText = " select convert(varchar(10),TimeInDate,103) DateIn , TimeInSh Sh , WheelType , count(*) cnt" & _
                    " from mm_vw_WheelNormalisingDetails " & _
                    " where TimeInDate = @TimeInDate and TimeInSh = @TimeInSh" & _
                    " group by convert(varchar(10),TimeInDate,103) , TimeInSh , WheelType union" & _
                    " select convert(varchar(10),TimeInDate,103)  , 'Total' , 'Charge' , count(*) cnt" & _
                    " from mm_vw_WheelNormalisingDetails" & _
                    " where TimeInDate = @TimeInDate and TimeInSh = @TimeInSh" & _
                    " group by convert(varchar(10),TimeInDate,103) , TimeInSh  ; " & _
                    " select convert(varchar(10),TimeOutDate,103) DateOut , TimeOutSh Sh , WheelType , count(*) cnt" & _
                    " from mm_vw_WheelNormalisingDetails " & _
                    " where TimeOutDate = @TimeInDate and TimeOutSh = @TimeInSh" & _
                    " group by convert(varchar(10),TimeOutDate,103) , TimeOutSh , WheelType union" & _
                    " select convert(varchar(10),TimeOutDate,103)  , 'Total' , 'DisCharge' , count(*) cnt" & _
                    " from mm_vw_WheelNormalisingDetails" & _
                    " where TimeOutDate = @TimeInDate and TimeOutSh = @TimeInSh" & _
                    " group by convert(varchar(10),TimeOutDate,103) , TimeOutSh  "
                da.Fill(ds)
                Return ds.Copy
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function
        Public Shared Function GetPreNFWheel(ByVal PedNo As Integer, ByVal Position As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                If PedNo = 46 Then
                    PedNo = 1
                ElseIf PedNo = 47 Then
                    PedNo = 2
                ElseIf PedNo = 48 Then
                    PedNo = 3
                Else
                    PedNo = PedNo + 3
                End If
                da.SelectCommand.Parameters.Add("@PedNo", SqlDbType.Int, 4).Value = PedNo
                da.SelectCommand.Parameters.Add("@Position", SqlDbType.VarChar, 1).Value = Position
                da.SelectCommand.CommandText = "select top 1 HeatNo , WheelNo , PedNo , PedPosition , TimeIn , wheel_type , a.SlNo " & _
                    " from mm_WheelNormalising a inner join mm_pouring b on HeatNo = Heat_number and WheelNo = engraved_number " & _
                    " where PedNo = @PedNo and PedPosition = @Position order by TimeIn desc "
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function
        Public Shared Function GetNFWheels(ByVal HeatNumber As Double, ByVal Type As Int16) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                If Type = 0 Then
                    da.SelectCommand.CommandText = " select Wh , WheelNo , wheel_type from (" & _
                        " select row_number() over ( order by Wh ) Sl , Wh , WheelNo , wheel_type " & _
                        " from mm_vw_WheelNormalising where HeatNo = @HeatNumber ) a where Sl between 1 and 10 " & _
                        " order by Wh ; "
                ElseIf Type = 1 Then
                    da.SelectCommand.CommandText = " select Wh , WheelNo , wheel_type from (" & _
                        " select row_number() over ( order by Wh ) Sl , Wh , WheelNo , wheel_type " & _
                        " from mm_vw_WheelNormalising where HeatNo = @HeatNumber ) a where Sl between 11 and 20 " & _
                        " order by Wh ; "
                ElseIf Type = 2 Then
                    da.SelectCommand.CommandText = " select Wh , WheelNo , wheel_type from (" & _
                        " select row_number() over ( order by Wh ) Sl , Wh , WheelNo , wheel_type " & _
                        " from mm_vw_WheelNormalising where HeatNo = @HeatNumber ) a where Sl between 21 and 30 " & _
                        " order by Wh ; "
                Else
                    da.SelectCommand.CommandText = " select Wh , WheelNo , wheel_type from (" & _
                        " select row_number() over ( order by Wh ) Sl , Wh , WheelNo , wheel_type " & _
                        " from mm_vw_WheelNormalising where HeatNo = @HeatNumber ) a where Sl > 30  " & _
                        " order by Wh ; "
                End If
                da.SelectCommand.Parameters.Add("@HeatNumber", SqlDbType.BigInt, 9).Value = HeatNumber
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function
        Public Shared Function GetMRXCReasons(ByVal MRXC As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.Parameters.Add("@MRXC", SqlDbType.VarChar, 50).Value = MRXC
                da.SelectCommand.CommandText = " select MRXC , Reasons , XCId " & _
                    " from mm_MRXCReasons where MRXC = @MRXC order by Reasons "
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function
        Public Shared Function GetMRXCWheelDetails(ByVal TappedDate As Date) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.Parameters.Add("@TappedDate", SqlDbType.SmallDateTime, 4).Value = TappedDate
                da.SelectCommand.CommandText = " select rtrim(status) MRXC ,  b.wheel_number Whl  , " & _
                    " a.heat_number  Heat , pour_order PO , rtrim(description) WhlType , Reasons , d.Remarks , " & _
                    " LIC , SIC from mm_vw_HeatTapped a inner join mm_wheel b" & _
                    " on a.heat_number = b.heat_number inner join mm_pouring c" & _
                    " on b.heat_number = c.heat_number and b.wheel_number = c.engraved_number" & _
                    " and status = rejection_code left outer join mm_vw_MRXCDetails d " & _
                    " on b.heat_number = d.HeatNo and b.wheel_number = d.WheelNo " & _
                    " where TappedDate = @TappedDate and location = 'mopo'" & _
                    " and status like 'x%' order by rtrim(status) , a.heat_number,  b.wheel_number"
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function
        Public Shared Function PopulateOffloadsList() As DataSet
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            da.SelectCommand.CommandText = "Select rtrim(machine_code) machine_code from ms_machinery_master " & _
                " where machine_code like 'moq%'  order by rtrim(machine_code) ; " & _
                " select 'OK' code union " & _
                " select code from mm_mmofrej_dump  where code not like '[0,1,2,3,4,5,6,7,8,9,x]%' and code <> 'ok' "
            Try
                da.Fill(ds)
                PopulateOffloadsList = ds.Copy
            Catch exp As Exception
                PopulateOffloadsList = Nothing
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function
        Public Shared Function PopulateWheelsGrid(ByVal HeatNumber As Double, Optional ByVal Type As Integer = 0) As DataSet
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Dim strHeatCheck, strWheels As String
            If Type = 1 Then
                da.SelectCommand.CommandText = " select heat_number Heat , engraved_number Whl , " & _
                    " pouring_order PO , rtrim(rejection_code) Sts from mm_pouring " & _
                    " where heat_number = @HeatNumber  and engraved_number not in ( " & _
                    " select WheelNo from mm_OffloadList where HeatNo = @HeatNumber ) " & _
                    " and rejection_code not in ('6','7','6&7')  " & _
                    " order by engraved_number ; " & _
                    " select WheelNo Whl , HeatNo , convert(varchar(10),OffDate,103) OffDate , " & _
                    " Shift Sh , Quencher , Offload , Processed from mm_OffloadList " & _
                    " where HeatNo = @HeatNumber order by WheelNo "

            ElseIf Type = 0 Then
                da.SelectCommand.CommandText = "select a.heat_number Heat , engraved_number Whl , " & _
                        " pouring_order PO , rtrim(rejection_code) Sts from mm_pouring a" & _
                        " left outer join ( select heat_number, wheel_number, max(sl_no) Sl_No " & _
                        " from mm_MouldRoom_Offloads group by heat_number, wheel_number " & _
                        " ) b on b.heat_number = a.heat_number and b.wheel_number = engraved_number" & _
                        " where a.heat_number = @HeatNumber and b.heat_number is null" & _
                        " and rejection_code not in ( '6' , '6&7' , 'x%' ) order by pouring_order ; " & _
                        " select a.sl_no, a.heat_number HtNo, pouring_order PO , " & _
                        " wheel_number Whl , WhlTemp , TopDia TopD , BottomDia BotD ," & _
                        " McnCode Mcn ,  OffLdCode OffCode , a.Remarks from mm_MouldRoom_Offloads a " & _
                        " inner join mm_pouring b on a.heat_number = b.heat_number and wheel_number = engraved_number " & _
                        " where a.heat_number = @HeatNumber  order by pouring_order "
            ElseIf Type = 2 Then
                da.SelectCommand.CommandText = "select a.heat_number Heat , engraved_number Whl , " & _
                        " pouring_order PO , rtrim(rejection_code) Sts from mm_pouring a" & _
                        " left outer join ( select HeatNo heat_number, WheelNo wheel_number, max(OffID) Sl_No " & _
                        " from mm_MROffloadWheels group by HeatNo, WheelNo " & _
                        " ) b on b.heat_number = a.heat_number and b.wheel_number = engraved_number" & _
                        " where a.heat_number = @HeatNumber and b.heat_number is null" & _
                        " and rejection_code not in ( '6' , '6&7' ) order by pouring_order ; " & _
                        " select WheelNo , HeatNo , OffLoadType , SIC , OffCode , PresentCode , OffID , Remarks , " & _
                        " convert(varchar(10),PresentStsDate,103)PresentStsDt , PresentSIC " & _
                        " from mm_MROffloadWheels a inner join mm_MROffloadType b on a.TypeID = b.TypeID " & _
                        " where HeatNo =  @HeatNumber "
            End If

            da.SelectCommand.Parameters.Add("@HeatNumber", SqlDbType.BigInt, 9).Value = HeatNumber
            Try
                da.Fill(ds)
                PopulateWheelsGrid = ds.Copy
            Catch exp As Exception
                PopulateWheelsGrid = Nothing
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function
        Public Shared Function GetOffloadedHeatDetails(ByVal HeatNo As Double) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.Parameters.Add("@HeatNo", SqlDbType.BigInt, 8).Value = HeatNo
                da.SelectCommand.CommandText = " select row_number() over ( order by WheelNo ) Sl ,  " &
                    " WheelNo Whl , OffLoadType , SIC , OffCode , PresentCode , " &
                    " Remarks , convert(varchar(10),PresentStsDate,103) PresentStsDt  , PresentSIC  " &
                    " from mm_MROffloadWheels a inner join mm_MROffloadType b on a.TypeID = b.TypeID " &
                    " where HeatNo = @HeatNo order by WheelNo "
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function
        Public Shared Function GetOffloadedWheelsDetails(ByVal HeatNo As Double, ByVal WheelNo As Double) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.Parameters.Add("@HeatNo", SqlDbType.BigInt, 8).Value = HeatNo
                da.SelectCommand.Parameters.Add("@WheelNo", SqlDbType.BigInt, 8).Value = WheelNo
                da.SelectCommand.CommandText = " select * from mm_MROffloadWheels " & _
                        " where HeatNo = @HeatNo and WheelNo = @WheelNo "
                da.Fill(ds)
                If ds.Tables(0).Rows.Count = 0 Then
                    Throw New Exception("InValid WheelNo !")
                End If
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function
        Public Shared Function PopulateDdls() As DataSet
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            da.SelectCommand.CommandText = "Select rtrim(machine_code) machine_code from ms_machinery_master " & _
                " where machine_code like 'mohub%' and machine_code <> 'MOHUB5' order by rtrim(machine_code) ; " & _
                " select 'OK' code union " & _
                " select code from mm_mmofrej_dump  where code not like '[0,1,2,3,4,5,6,7,8,9,x]%' and code <> 'ok' "
            Try
                da.Fill(ds)
                PopulateDdls = ds.Copy
            Catch exp As Exception
                PopulateDdls = Nothing
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
            End Try
        End Function
        Public Shared Function GetHeats(ByVal MRDate As Date, ByVal Shift As String, Optional ByVal Mode As Boolean = False) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                If Mode Then
                    da.SelectCommand.CommandText = "select top 9 a.heat_number , shift_supervisor from mm_vw_HeatTapped a " & _
                        " inner join mm_pouring b on b.heat_number = a.heat_number and pouring_order = 1 " & _
                        " inner join mm_pre_pouring c on c.heat_number = a.heat_number " & _
                        " where TappedDate = @TappedDate  and TappedShift =  @TappedShift " & _
                        " ORDER BY a.heat_number desc "
                Else
                    da.SelectCommand.CommandText = "select top 9 a.heat_number , shift_supervisor from mm_vw_HeatTapped a " & _
                        " inner join mm_pouring b on b.heat_number = a.heat_number and pouring_order = 1 " & _
                        " inner join mm_pre_pouring c on c.heat_number = a.heat_number " & _
                        " where TappedDate = @TappedDate  " & _
                        " ORDER BY a.heat_number desc "
                End If
                da.SelectCommand.Parameters.Add("@TappedDate", SqlDbType.SmallDateTime, 4).Value = MRDate
                da.SelectCommand.Parameters.Add("@TappedShift", SqlDbType.VarChar, 1).Value = Shift
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function
        Public Shared Function GetSingleHeatWheels(ByVal HeatNumber As Double, ByVal Type As Int16) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                If Type = 0 Then
                    da.SelectCommand.CommandText = " select top 18 engraved_number Wh , WheelNo , " & _
                        " OffCode OffC , PresentCode PrnSts , ClearedSts FinSts from mm_pouring a " & _
                        " left outer join mm_MROffloadWheels b on HeatNo = Heat_number and WheelNo = engraved_number " & _
                        " where heat_number = @HeatNumber and rejection_code not in ( '6' , '6&7' , 'x%' )" & _
                        " and pouring_order between 1 and 18 " & _
                        " order by pouring_order ; "
                Else
                    da.SelectCommand.CommandText = " select engraved_number Wh , WheelNo , " & _
                        " OffCode OffC , PresentCode PrnSts , ClearedSts FinSts from mm_pouring a " & _
                        " left outer join mm_MROffloadWheels b on HeatNo = Heat_number and WheelNo = engraved_number " & _
                        " where heat_number = @HeatNumber and rejection_code not in ( '6' , '6&7' , 'x%' )" & _
                        " and pouring_order > 18 " & _
                        " order by pouring_order ; "
                End If

                da.SelectCommand.Parameters.Add("@HeatNumber", SqlDbType.BigInt, 9).Value = HeatNumber
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function
        Public Shared Function GetHeatWheels(ByVal HeatNumber As Double, ByVal Type As Int16) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                If Type = 0 Then
                    da.SelectCommand.CommandText = " select top 18 engraved_number Wh , WheelNo from mm_pouring a " & _
                        " left outer join mm_MROffloadWheels b on HeatNo = Heat_number and WheelNo = engraved_number " & _
                        " where heat_number = @HeatNumber and rejection_code not in ( '6' , '6&7' , 'x%' )" & _
                        " and pouring_order between 1 and 18 " & _
                        " order by pouring_order ; "
                Else
                    da.SelectCommand.CommandText = " select engraved_number Wh , WheelNo from mm_pouring a " & _
                        " left outer join mm_MROffloadWheels b on HeatNo = Heat_number and WheelNo = engraved_number " & _
                        " where heat_number = @HeatNumber and rejection_code not in ( '6' , '6&7' , 'x%' )" & _
                        " and pouring_order > 18 " & _
                        " order by pouring_order ; "
                End If

                da.SelectCommand.Parameters.Add("@HeatNumber", SqlDbType.BigInt, 9).Value = HeatNumber
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function
        Public Shared Function GetMROffloadType() As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select OffLoadType , TypeID from mm_MROffloadType"
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function
        Public Shared Function GetPouringTubes(ByVal Dt As Date) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.CommandText = "mm_sp_PouringTubes"
                da.SelectCommand.Parameters.Add("@Dt", SqlDbType.SmallDateTime, 4).Value = Dt
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function
        Public Shared Function GetNFTempTimeData(ByVal NFDate As Date, ByVal Sh As String, ByVal NFTime As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select temperature_zone2 Z2 , " & _
                    " temperature_zone3 Z3 , temperature_zone4 Z4 , temperature_zone5 Z5 , " & _
                    " temperature_zone6 Z6 , temperature_zone7 Z7 , combustion_gas Com , flue_gas Flu , Remarks " & _
                    " from mm_normalising_furnace_temperature " & _
                    " where nf_date = @nf_date AND shift_code = @shift_code " & _
                    " and temerature_reading_time = @NFTime "
                da.SelectCommand.Parameters.Add("@nf_date", SqlDbType.SmallDateTime, 4).Value = NFDate
                da.SelectCommand.Parameters.Add("@shift_code", SqlDbType.VarChar, 1).Value = Sh
                da.SelectCommand.Parameters.Add("@NFTime", SqlDbType.VarChar, 5).Value = NFTime
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function GetDFTempTimeData(ByVal DFDate As Date, ByVal Sh As String, ByVal DFTime As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select temperature_zone1 Z1 , " & _
                    " temperature_zone2 Z2 , temperature_zone3 Z3 , temperature_zone4 Z4 , temperature_zone5 Z5 , " & _
                    " temperature_zone6 Z6 , temperature_zone7 Z7 , temperature_zone8 Z8 , Remarks " & _
                    " from mm_draw_furnace_temperatures " & _
                    " where df_date = @df_date AND shift_code = @shift_code " & _
                    " and temerature_reading_time = @DFTime "
                da.SelectCommand.Parameters.Add("@df_date", SqlDbType.SmallDateTime, 4).Value = DFDate
                da.SelectCommand.Parameters.Add("@shift_code", SqlDbType.VarChar, 1).Value = Sh
                da.SelectCommand.Parameters.Add("@DFTime", SqlDbType.VarChar, 5).Value = DFTime
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function GetNFTempData(ByVal NFDate As Date, ByVal Sh As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select temerature_reading_time NFTime , " & _
                    " temperature_zone2 Z2 , temperature_zone3 Z3 , temperature_zone4 Z4 , temperature_zone5 Z5 , " & _
                    " temperature_zone6 Z6 , temperature_zone7 Z7 , " & _
                    " combustion_gas Com , flue_gas Flu , Remarks " & _
                    " from mm_normalising_furnace_temperature " & _
                    " where nf_date = @nf_date AND shift_code = @shift_code "
                da.SelectCommand.Parameters.Add("@nf_date", SqlDbType.SmallDateTime, 4).Value = NFDate
                da.SelectCommand.Parameters.Add("@shift_code", SqlDbType.VarChar, 1).Value = Sh
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                da = Nothing
                ds = Nothing
            End Try
        End Function
        Public Shared Function GetDFTempData(ByVal DFDate As Date, ByVal Sh As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select temerature_reading_time NFTime , temperature_zone1 Z1 , " & _
                    " temperature_zone2 Z2 , temperature_zone3 Z3 , temperature_zone4 Z4 , temperature_zone5 Z5 , " & _
                    " temperature_zone6 Z6 , temperature_zone7 Z7 , temperature_zone8 Z8 , Remarks " & _
                    " from mm_draw_furnace_temperatures " & _
                    " where df_date = @df_date AND shift_code = @shift_code "
                da.SelectCommand.Parameters.Add("@df_date", SqlDbType.SmallDateTime, 4).Value = DFDate
                da.SelectCommand.Parameters.Add("@shift_code", SqlDbType.VarChar, 1).Value = Sh
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function GetNFRemainingHeatWhls(ByVal heat_number As Long) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select pouring_order PO , " & _
                    " a.engraved_number Whl from mm_pouring a " & _
                    " left outer join mm_normalizing_furnace_loading b " & _
                    " on a.heat_number = b.heat_number and a.engraved_number = wheel_number" & _
                    " where a.heat_number = @heat_number " & _
                    " and b.heat_number is null order by pouring_order  "
                da.SelectCommand.Parameters.Add("@heat_number", SqlDbType.BigInt, 8).Value = heat_number
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function GetNFHeatData(ByVal Cold As Int16, ByVal heat_number As Long, ByVal NFDate As Date, ByVal NFSh As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                If Cold = 0 Then
                    da.SelectCommand.CommandText = "select row_number() over ( order by charge_in_time ) Sl , " & _
                        " convert(varchar(10),loading_date,103) LoadDt , shift_code Sh ," & _
                        " wheel_number Wh , heat_number Ht , pedestral_number PNo , " & _
                        " convert(varchar(5),charge_in_time,114) InTime , " & _
                        " convert(varchar(5),charge_out_time,114) OutTime , offload_code Offl , quenched_number QNo , " & _
                        " temperature_on_discharge DisTemp , quenching_duration QDur , " & _
                        " hubcooling_duration HCDur , NFTemp , Remarks from mm_normalizing_furnace_loading " & _
                        " where heat_number = @heat_number order by charge_in_time desc "
                    da.SelectCommand.Parameters.Add("@heat_number", SqlDbType.BigInt, 8).Value = heat_number
                Else
                    da.SelectCommand.CommandText = "select row_number() over ( order by charge_in_time  , sl_no ) Sl , " & _
                        " convert(varchar(10),loading_date,103) LoadDt , shift_code Sh ," & _
                        " wheel_number Wh , heat_number Ht , pedestral_number PNo , " & _
                        " convert(varchar(5),charge_in_time,114) InTime , " & _
                        " convert(varchar(5),charge_out_time,114) OutTime , offload_code Offl , quenched_number QNo , " & _
                        " temperature_on_discharge DisTemp , quenching_duration QDur , " & _
                        " hubcooling_duration HCDur , NFTemp , Remarks from mm_normalizing_furnace_loading " & _
                        " where loading_date = @NFDate and shift_code = @NFSh " & _
                        " and Cold = 1 order by charge_in_time desc , sl_no desc "
                    da.SelectCommand.Parameters.Add("@NFDate", SqlDbType.SmallDateTime, 4).Value = NFDate
                    da.SelectCommand.Parameters.Add("@NFSh", SqlDbType.VarChar, 1).Value = NFSh
                End If

                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function GetNFData(ByVal Dt As Date, ByVal Sh As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select wheel_number Wh , heat_number Ht , pedestral_number PedNo , " & _
                    " convert(varchar(10),charge_in_time,103) InDate , convert(varchar(5),charge_in_time,114) InTime , " & _
                    " convert(varchar(10),charge_out_time,103) OutDt , convert(varchar(5),charge_out_time,114) OutTime , " & _
                    " offload_code Offl , quenched_number QNo , " & _
                    " temperature_on_discharge DisTemp , quenching_duration QDur , " & _
                    " hubcooling_duration HCDur , NFTemp , Remarks from mm_normalizing_furnace_loading " & _
                    " where loading_date = @Dt and shift_code = @Sh "
                da.SelectCommand.Parameters.Add("@Dt", SqlDbType.SmallDateTime, 4).Value = Dt
                da.SelectCommand.Parameters.Add("@Sh", SqlDbType.VarChar, 1).Value = Sh
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function GetWheelData(ByVal Wh As Integer, ByVal Ht As Long, ByVal Dt As Date, ByVal Sh As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select * from mm_normalizing_furnace_loading " &
                    " where loading_date = @Dt and shift_code = @Sh" &
                    " and wheel_number = @Wh and heat_number = @Ht "
                da.SelectCommand.Parameters.Add("@Dt", SqlDbType.SmallDateTime, 4).Value = Dt
                da.SelectCommand.Parameters.Add("@Sh", SqlDbType.VarChar, 1).Value = Sh
                da.SelectCommand.Parameters.Add("@Wh", SqlDbType.Int, 4).Value = Wh
                da.SelectCommand.Parameters.Add("@Ht", SqlDbType.BigInt, 4).Value = Ht
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function

        Public Function WheelNFLoading1(ByVal loading_date As Date, ByVal shift_code As String, ByVal operator_code As String, ByVal supervisor As String,
                                        ByVal wheel_number As Integer, ByVal heat_number As Long, ByVal wheel_sr_no As String, ByVal Cold As Int16, ByVal pour_order As Integer, ByVal srbit As Integer, Optional ByVal Sl_No As Long = 0) As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj

            cmd.Parameters.Add("@loading_date", SqlDbType.SmallDateTime, 4).Value = loading_date
            cmd.Parameters.Add("@shift_code", SqlDbType.VarChar, 1).Value = shift_code
            cmd.Parameters.Add("@operator_code", SqlDbType.VarChar, 50).Value = operator_code
            cmd.Parameters.Add("@supervisor", SqlDbType.VarChar, 50).Value = supervisor
            cmd.Parameters.Add("@wheel_number", SqlDbType.Int, 4).Value = wheel_number
            cmd.Parameters.Add("@heat_number", SqlDbType.BigInt, 8).Value = heat_number
            cmd.Parameters.Add("@wheel_sr_no", SqlDbType.VarChar, 10).Value = wheel_sr_no
            cmd.Parameters.Add("@Cold", SqlDbType.Int, 4).Value = Cold
            cmd.Parameters.Add("@Sl_No", SqlDbType.BigInt, 8).Direction = ParameterDirection.Output
            cmd.Parameters.Add("@pour_order", SqlDbType.Int, 4).Value = pour_order
            cmd.Parameters.Add("@srbit", SqlDbType.Int, 4).Value = srbit



            Dim NFTemp As String
            Dim NF As Int16


            Dim blnDone As Boolean
            Try
                cmd.Connection.Open()
                cmd.Transaction = cmd.Connection.BeginTransaction
                cmd.CommandText = " select @sl_no = isnull(sl_no,0) from mm_nf_loading " &
                    " where loading_date = @loading_date and shift_code = @shift_code " &
                    " and wheel_number = @wheel_number and heat_number = @heat_number "
                cmd.ExecuteScalar()
                cmd.Parameters("@Sl_No").Direction = ParameterDirection.Input
                If IIf(IsDBNull(cmd.Parameters("@Sl_No").Value), 0, cmd.Parameters("@Sl_No").Value) = 0 Then
                    cmd.CommandText = " insert into mm_nf_loading ( loading_date , shift_code , " &
                        " operator_code , supervisor , wheel_number , heat_number , wheel_sr_no, Cold ,pour_order,srbit)" &
                        " values ( @loading_date , @shift_code , @operator_code , @supervisor , @wheel_number , " &
                        " @heat_number , @wheel_sr_no , @Cold, @pour_order,@srbit) "
                Else
                    cmd.CommandText = " update mm_nf_loading set" &
                    " operator_code = @operator_code , supervisor = @supervisor , " &
                    " wheeltmp_at_rq=@wheeltmp_at_rq, wheelouttmp_aft_nf=@wheelouttmp_aft_nf," &
                    " wheel_sr_no=@wheel_sr_no,Cold = @Cold ,pour_order=@pour_order,srbit=@srbit" &
                    " where loading_date = @loading_date and shift_code = @shift_code and" &
                    " wheel_number = @wheel_number and heat_number = @heat_number and Sl_No = @Sl_No "
                End If
                If cmd.ExecuteNonQuery = 1 Then blnDone = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If IsNothing(cmd.Transaction) = False Then
                    If blnDone = False Then
                        cmd.Transaction.Rollback()
                    Else
                        cmd.Transaction.Commit()
                    End If
                End If
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            NFTemp = Nothing
            NF = Nothing
            Return blnDone
        End Function

        Public Shared Function GetWheelData1(ByVal Wh As Integer, ByVal Ht As Long, ByVal Dt As Date, ByVal Sh As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select * from mm_nf_loading " &
                    " where loading_date = @Dt And shift_code = @Sh" &
                    " And wheel_number = @Wh And heat_number = @Ht "
                da.SelectCommand.Parameters.Add("@Dt", SqlDbType.SmallDateTime, 4).Value = Dt
                da.SelectCommand.Parameters.Add("@Sh", SqlDbType.VarChar, 1).Value = Sh
                da.SelectCommand.Parameters.Add("@Wh", SqlDbType.Int, 4).Value = Wh
                da.SelectCommand.Parameters.Add("@Ht", SqlDbType.BigInt, 4).Value = Ht
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function

        Public Shared Function GetNFRemainingHeatWhls1(ByVal heat_number As Long) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                'da.SelectCommand.CommandText = "select pour_order PO , " &
                '    " a.wheel_number Whl from mm_wheel_test a " &
                '    " left outer join mm_nf_loading b " &
                '    " on a.heat_number = b.heat_number and a.wheel_number = b.wheel_number" &
                '    " where a.heat_number = @heat_number " &
                '    " and b.heat_number is null order by pour_order  "
                da.SelectCommand.CommandText = "select pour_order,heat_number,wheel_number,description from mm_wheel where heat_number=@heat_number  order by pour_order"
                da.SelectCommand.Parameters.Add("@heat_number", SqlDbType.BigInt, 8).Value = heat_number
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function

        Public Shared Function getheatdata(ByVal Dt As DateTime) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select heat_number,wheel_number,wheel_sr_no from mm_nf_loading  where loading_date=@Dt " &
                    " order by loading_date desc"
                da.SelectCommand.Parameters.Add("@Dt", SqlDbType.DateTime, 4).Value = Dt
                ' da.SelectCommand.Parameters.Add("@Sh", SqlDbType.VarChar, 1).Value = Sh
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function

        Public Shared Function CheckWheel(ByVal Wh As Integer, ByVal Ht As Long) As Boolean
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            oCmd.Parameters.Add("@cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output
            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.CommandText = "select @cnt = count(*) from mm_wheel " &
                    " where wheel_number = " & Wh & "  and heat_number = " & Ht & " "
                oCmd.ExecuteScalar()
                CheckWheel = IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value)
            Catch exp As Exception
                CheckWheel = ""
                Throw New Exception(exp.Message)
            Finally
                If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
            End Try
        End Function
        Public Shared Function CheckMRShiftDetailsDate(ByVal ShDate As Date, ByVal Shift As String) As Boolean
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            oCmd.Parameters.Add("@ShiftDate", SqlDbType.SmallDateTime, 4).Direction = ParameterDirection.Output
            oCmd.Parameters.Add("@Shift", SqlDbType.VarChar, 1).Direction = ParameterDirection.Output
            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.CommandText = "select top 1  @ShiftDate = TappedDate ,  @Shift = TappedShift from mm_MRShiftDetails"
                oCmd.ExecuteScalar()
                If ShDate = IIf(IsDBNull(oCmd.Parameters("@ShiftDate").Value), "1900-01-01", oCmd.Parameters("@ShiftDate").Value) Then
                    If Shift = IIf(IsDBNull(oCmd.Parameters("@Shift").Value), "", oCmd.Parameters("@Shift").Value) Then
                        CheckMRShiftDetailsDate = True
                    End If
                End If
            Catch exp As Exception
                CheckMRShiftDetailsDate = False
                Throw New Exception(exp.Message)
            Finally
                If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
            End Try
        End Function
        Public Shared Function GetMRShiftDetailsDate() As String
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            oCmd.Parameters.Add("@ShiftDetailsDate", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output
            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.CommandText = "select top 1  @ShiftDetailsDate = convert(varchar(10),TappedDate,103)+' and Shift : '+TappedShift from mm_MRShiftDetails"
                oCmd.ExecuteScalar()
                GetMRShiftDetailsDate = IIf(IsDBNull(oCmd.Parameters("@ShiftDetailsDate").Value), "", oCmd.Parameters("@ShiftDetailsDate").Value)
            Catch exp As Exception
                GetMRShiftDetailsDate = ""
                Throw New Exception(exp.Message)
            Finally
                If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
            End Try
        End Function
        Public Shared Function CheckShift(ByVal ShDate As Date, ByVal Shift As String) As Boolean
            Dim PresentDate As Date
            Dim PresentShift As String
            Try
                If Now.Hour = 0 OrElse Now.Hour = 1 OrElse Now.Hour = 2 OrElse Now.Hour = 3 OrElse Now.Hour = 4 OrElse Now.Hour = 5 Then
                    PresentDate = Now.Date.AddDays(-1)
                Else
                    PresentDate = Now.Date
                End If
                Select Case Now.Hour
                    Case 6 To 13
                        PresentShift = "A"
                    Case 14 To 21
                        PresentShift = "B"
                    Case Else
                        PresentShift = "C"
                End Select
                If ShDate = PresentDate Then
                    If Shift > PresentShift Then
                        Throw New Exception("InValid Shift Selection!")
                    End If
                End If
                CheckShift = True
            Catch exp As Exception
                CheckShift = False
                Throw New Exception(exp.Message)
            Finally
                PresentDate = Nothing
                PresentShift = Nothing
            End Try
        End Function
        Public Shared Function RejectionProducingMoulds(ByVal Product As String, ByVal Type As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.CommandText = "mm_sp_RejectionProducingMoulds"
                da.SelectCommand.Parameters.Add("@Product", SqlDbType.VarChar, 50).Value = Product
                da.SelectCommand.Parameters.Add("@Type", SqlDbType.VarChar, 1).Value = Type
                da.SelectCommand.CommandTimeout = 3600
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function GetWhlType() As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select distinct rtrim(description) WHlType from mm_wheel " & _
                    " where heat_number >= 90000 and description <> '' "
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function GetNotPostedWheels() As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select wheelNumber Whl , HeatNumber Heat , a.description WheelType , WheelStatus , rtrim(status) MasterSts " & _
                    " from mm_magnaglow_shiftwiserecords_Deleted a inner join " & _
                    " ( select wheelNumber Whl , HeatNumber Heat , max(sl_no) sl_no" & _
                    " from mm_magnaglow_shiftwiserecords_Deleted " & _
                    " group by wheelNumber , HeatNumber ) b on a.sl_no = b.sl_no " & _
                    " inner join mm_wheel c on wheelNumber = wheel_Number and HeatNumber = Heat_Number " & _
                    " where convert(smalldatetime,convert(varchar(10),deletedtime,110)) = convert(smalldatetime,convert(varchar(10),getdate(),110)) "
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function GetMRWhlData(ByVal whl As Double, ByVal Ht As Double) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.Parameters.Add("@Whl", SqlDbType.BigInt, 8).Value = whl
                da.SelectCommand.Parameters.Add("@Ht", SqlDbType.BigInt, 8).Value = Ht
                da.SelectCommand.CommandText = "select rtrim(description) WheelType , convert(varchar(10), a.pour_time, 103) PourDt ,  " & _
                    " rtrim(rejection_code) MRSts , rtrim(remarks) MRRemarks " & _
                    " from mm_pouring a inner join mm_wheel b on a.engraved_number = b.wheel_number and a.heat_number = b.heat_number " & _
                    " where b.wheel_number = @Whl And a.heat_number = @Ht" & _
                    " and location = 'mopo' "
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function GetWhlData(ByVal whl As Double, ByVal Ht As Double) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.Parameters.Add("@Whl", SqlDbType.BigInt, 8).Value = whl
                da.SelectCommand.Parameters.Add("@Ht", SqlDbType.BigInt, 8).Value = Ht
                da.SelectCommand.CommandText = "select b.wheel_number Whl , b.heat_number Ht , " & _
                    " convert(varchar(10), a.test_date, 103) TestDt , a.time_entered TestTime ," & _
                    " a.shift_code Sh , rtrim(a.line_number) Line ," & _
                    " rtrim(a.wheel_status) WhlSts , a.grind_status GrindSts , a.mcn_operation MCNOp" & _
                    " from mm_magnaglow_results a inner join mm_wheel b " & _
                    " on a.wheel_number = b.wheel_number and a.heat_number = b.heat_number" & _
                    " where a.wheel_number = @Whl And a.heat_number = @Ht" & _
                    " and ( a.wheel_status in ( 'xc2' , 'xc31' , 'xc32' , 'xc33' , 'xc46' , 'xc56' ) or a.wheel_status  like 'xc31%' " & _
                    " or a.wheel_status  like 'xc51%' or a.wheel_status  like 'xc46%' or a.wheel_status  like 'xc56%')" & _
                    " order by a.sl_no desc "
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function CheckBatch(ByVal Batch As String, ByVal BatchDate As Date, ByVal Sl As Int16) As Boolean
            Dim MinSl As Int16
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            oCmd.Parameters.Add("@Sl", SqlDbType.Int, 4).Direction = ParameterDirection.Output
            oCmd.Parameters.Add("@BatchDate", SqlDbType.SmallDateTime, 4).Value = BatchDate
            oCmd.Parameters.Add("@batch", SqlDbType.VarChar, 10).Value = Batch
            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.CommandText = "select @Sl = count(sample_batch_number) from mm_sand_system  " & _
                    " where sand_date = @BatchDate and sample_batch_number = @batch "
                oCmd.ExecuteScalar()
                If IIf(IsDBNull(oCmd.Parameters("@Sl").Value), 0, oCmd.Parameters("@Sl").Value) = 0 Then
                    Select Case Left(Batch, 3)
                        Case "P-D"
                            oCmd.CommandText = "select @Sl = max(Sl) from mm_sand_system a " & _
                            " inner join mm_SandBatches c on Batch = sample_batch_number" & _
                            " where a.sand_date = @BatchDate and Type in ( 3 )"
                            MinSl = 21
                        Case "P-S"
                            oCmd.CommandText = "select @Sl = max(Sl) from mm_sand_system a " & _
                            " inner join mm_SandBatches c on Batch = sample_batch_number" & _
                            " where a.sand_date = @BatchDate and Type in ( 4 , 5 )"
                            MinSl = 25
                        Case Else
                            oCmd.CommandText = "select @Sl = max(Sl) from mm_sand_system a " & _
                            " inner join mm_SandBatches c on Batch = sample_batch_number" & _
                            " where a.sand_date = @BatchDate and Type in ( 1 , 2 )"
                            MinSl = 0
                    End Select
                    oCmd.ExecuteScalar()
                    If Sl = IIf(IsDBNull(oCmd.Parameters("@Sl").Value), MinSl, oCmd.Parameters("@Sl").Value) + 1 Then Return True
                Else
                    Return True
                End If
            Catch exp As Exception
                Return False
                Throw New Exception(exp.Message)
            Finally
                If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
                MinSl = Nothing
            End Try
        End Function
        Public Shared Function SandBatchPrepared(ByVal dt As Date) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select  convert(varchar(11),a.sand_date,103) SandDt , shift_code Sh ," & _
                    " resin_supplier Firm , sample_batch_number Batch , " & _
                    " capacitrol_set_point SetP , dried_sand_in_kgs DrySand , " & _
                    " convert(decimal(5,2),Resin_in_kg) ResinKg ,  resin_in_percentage ResinPer , " & _
                    " wet_mull_time Wet , dry_mull_time Dry , hexa_solution_percentage Sol ," & _
                    " hexa_powder_percentage Powder ,  free_water H2O , hexamin_supplier HexaFirm , " & _
                    " convert(varchar(11),b.date_tested,103) TestDt , b.sand_cts CTS ,  " & _
                    " b.sand_hts HTS , b.sand_stick_point SP , Type  " & _
                    " from mm_sand_system a left outer join mm_vw_si_sandresults b  " & _
                    " on a.sample_batch_number = b.batch_number and a.sand_date = b.date_prepared  " & _
                    " inner join mm_SandBatches c on Batch = sample_batch_number " & _
                    "where a.sand_date = @dt order by a.sand_date , Sl "
                da.SelectCommand.Parameters.Add("@dt", SqlDbType.SmallDateTime, 4).Value = dt
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function SandBatches() As DataSet
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "mm_sp_SandBatches"
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(ds)
                Return ds.Copy
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function CheckOutTurn(ByVal OutTurnDate As Date, ByVal Shift As String) As DataSet
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Dim ds As New DataSet()
            da.SelectCommand.CommandText = "select *  from mm_MROutTurn where OutTurnDate  = @OutTurnDate and Shift = @Shift "
            da.SelectCommand.Parameters.Add("@OutTurnDate", SqlDbType.SmallDateTime, 4).Value = CDate(OutTurnDate)
            da.SelectCommand.Parameters.Add("@Shift", SqlDbType.VarChar, 1).Value = Shift
            Try
                da.Fill(ds)
                Return ds.Copy
            Catch exp As Exception
                ds = Nothing
            Finally
                ds.Dispose()
                da.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function ShopGroundBalance(ByVal wo As String, ByVal SubShop As String, ByVal WODate As Date, ByVal Group As String)
            Dim cmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            Dim da As New SqlClient.SqlDataAdapter()
            Dim ds As New DataSet()
            Try
                cmd.Connection.Open()
                cmd.CommandText = "select number from mm_workorder where number like '" & wo.Trim & "'"
                da.SelectCommand = cmd
                da.Fill(ds, "woList")

                da.SelectCommand.CommandText = "select HD.hvpl plNo, HD.hvpldesc pl_Desc , hd.hvuom UOM, convert(float,0.0) OB, convert(float,0.0) Receipt "
                Dim row As DataRow
                For Each row In ds.Tables("woList").Rows
                    da.SelectCommand.CommandText &= ", convert(float,0) Consumed_" + row(0)
                Next
                da.SelectCommand.CommandText &= ", convert(float,0.0) CB FROM mm_vw_HighValueItems as HD, mm_ShopGround_ShopCode as SC WHERE hvshop LIKE SC.Shop_Code + '%' and SC.Group_Code LIKE '" & Group & "%' and HD.hvpl IN (SELECT pl_number FROM [rwfdb\rwfdbcluster].wap.dbo.pm_itemmaster) ORDER BY hvpl"
                da.Fill(ds, "PlList")
                da.SelectCommand.Parameters.Add("@Pl", SqlDbType.VarChar, 8).Direction = ParameterDirection.Input
                da.SelectCommand.Parameters.Add("@ShopCode", SqlDbType.VarChar, 4).Value = SubShop
                da.SelectCommand.Parameters.Add("@CurYear", SqlDbType.Int, 4).Value = CDate(WODate).Year
                da.SelectCommand.Parameters.Add("@CurMonth", SqlDbType.Int, 4).Value = CDate(WODate).Month

                da.SelectCommand.Parameters.Add("@wo", SqlDbType.VarChar, 4).Direction = ParameterDirection.Input
                da.SelectCommand.Parameters("@wo").Value = ""
                Dim deciClosingBalance As Decimal
                da.SelectCommand.Parameters.Add("@OB", SqlDbType.Float, 8).Direction = ParameterDirection.Output
                For Each row In ds.Tables("PlList").Rows
                    ' update OB 
                    da.SelectCommand.Parameters("@Pl").Value = row("plno")
                    da.SelectCommand.CommandText = "declare @Cb float " & _
                        " declare @OBCBDt smalldatetime " & _
                        " select @OBCBDt = max(record_date) from mm_shop_accountal where shop_code = @ShopCode " & _
                        " and pl_number = @Pl and record_date <= convert(smalldatetime,convert(varchar, @CurYear)+'-'+convert(varchar,@CurMonth)+'-01') " & _
                        " select @OB = closing_balance   from mm_shop_accountal where shop_code like @ShopCode+'%' and " & _
                        " record_date = @obcbdt and pl_number = @Pl "
                    Try
                        If da.SelectCommand.Connection.State = ConnectionState.Closed Then da.SelectCommand.Connection.Open()
                        row.BeginEdit()
                        da.SelectCommand.ExecuteScalar()
                        If IsDBNull(da.SelectCommand.Parameters("@OB").Value) Then
                            row("OB") = 0.0
                        Else
                            row("OB") = da.SelectCommand.Parameters("@OB").Value
                        End If
                        If IsDBNull(row("OB")) Then
                            row("OB") = 0.0
                        End If

                        da.SelectCommand.CommandText = "select isnull(sum(isnull(quantity_received,0.0)),0.0) QtyRecd from mm_shop_pl_receipt where shop_code like @ShopCode+'%' and " & _
                            " pl_number = @Pl  and year(receipt_date) = @CurYear and  month(receipt_date) = @CurMonth "
                        Dim receipt As Decimal
                        receipt = da.SelectCommand.ExecuteScalar
                        row("Receipt") = IIf(IsDBNull(receipt), 0.0, receipt)
                        If IsDBNull(row("Receipt")) = False Then
                            deciClosingBalance = CDec(row("OB")) + CDec(row("Receipt"))
                        Else
                            deciClosingBalance = CDec(row("OB")) + 0
                        End If

                        Dim rw As DataRow
                        Dim ij As Integer = -1
                        ij += 1
                        Dim woqty As Decimal
                        Dim woqnty As Decimal
                        For Each rw In ds.Tables("woList").Rows
                            da.SelectCommand.Parameters("@Wo").Value = rw("number")
                            da.SelectCommand.CommandText = "select isnull(Sum(isnull(quantity,0.0)),0.0)  " & _
                                                  " from mm_daily_pl_consumption where shop_code like @ShopCode+'%' and " & _
                                                  " pl_number = @Pl  and year(Consumed_date) = @CurYear and " & _
                                                  " month(Consumed_date) = @CurMonth and workorder_number = @wo "
                            woqty = da.SelectCommand.ExecuteScalar
                            If IsDBNull(woqty) Then woqnty = 0.0 Else woqnty = woqty
                            row(ij + 5) = woqnty
                            deciClosingBalance -= woqnty
                            ij += 1
                        Next
                        row("CB") = deciClosingBalance
                        row.EndEdit()
                        woqty = Nothing
                        woqnty = Nothing
                        ij = Nothing
                        rw = Nothing
                        receipt = Nothing
                    Catch exp As Exception
                        Throw New Exception(exp.Message)
                    Finally
                        If da.SelectCommand.Connection.State = ConnectionState.Open Then da.SelectCommand.Connection.Close()
                    End Try
                Next
                deciClosingBalance = Nothing
                row = Nothing
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
                cmd = Nothing
            End Try
            Return ds.Tables("PlList")
        End Function
        Public Shared Function PlList(ByVal Group As String, ByVal WOStr As String) As DataSet
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select HD.hvpl plNo, HD.hvpldesc pl_Desc , hd.hvuom UOM, convert(float,0.0) OB, convert(float,0.0) Receipt "
                da.SelectCommand.CommandText &= "WOStr"
                da.SelectCommand.CommandText &= ", convert(float,0.0) CB FROM mm_mmhvpl_dump as HD, mm_ShopGround_ShopCode as SC " & _
                    " WHERE hvshop LIKE SC.Shop_Code + '%' and SC.Group_Code LIKE '" & Group & "%' and HD.hvpl IN (SELECT pl_number FROM [rwfdb\rwfdbcluster].wap.dbo.pm_itemmaster) ORDER BY hvpl"
                da.Fill(ds, "PlList")
                Return ds.Copy
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function WONumbers(ByVal wo As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select number from mm_workorder where number like '" & wo.Trim & "'"
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function GetCostCentre(ByVal sUser As String) As String
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            oCmd.Parameters.Add("@CostCentre", SqlDbType.VarChar, 1).Direction = ParameterDirection.Output
            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.CommandText = "select @CostCentre = rtrim(ltrim(cost_center_code)) from mm_shop where code = '" & sUser & "'"
                oCmd.ExecuteScalar()
                GetCostCentre = IIf(IsDBNull(oCmd.Parameters("@CostCentre").Value), "", oCmd.Parameters("@CostCentre").Value)
            Catch exp As Exception
                GetCostCentre = ""
                Throw New Exception(exp.Message)
            Finally
                If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
            End Try
        End Function
        Public Shared Function ShopCodes(ByVal sUser As String) As DataSet
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select shop_code ,Group_code  from  mm_ShopGround_ShopCode ;" &
                    " select rtrim(A.stn_id)+'-'+rtrim(a.stn_desc) StnDesc, a.stn_id  from  mm_mmsdt_dump a inner join  mm_ShopGround_ShopCode b " &
                    " on A.stn_id like B.shop_code+'%' where B.group_code = '" & sUser & "'"

                da.Fill(ds)
                Return ds.Copy
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function

        Public Shared Function GetRecordDate(ByVal Shop As String) As Date
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            oCmd.Parameters.Add("@RecordDate", SqlDbType.SmallDateTime, 4).Direction = ParameterDirection.Output
            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.CommandText = "select @RecordDate = max(record_date) from mm_shop_accountal where shop_code like '" & Shop & "%'"
                oCmd.ExecuteScalar()
                GetRecordDate = IIf(IsDBNull(oCmd.Parameters("@RecordDate").Value), "1900-01-01", oCmd.Parameters("@RecordDate").Value)
                If DateDiff(DateInterval.Month, GetRecordDate, Now.Date) > 1 Then
                    GetRecordDate = GetRecordDate.AddMonths(1)
                End If
            Catch exp As Exception
                GetRecordDate = Nothing
                Throw New Exception(exp.Message)
            Finally
                If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
            End Try
        End Function

        Public Shared Function LadleWeights(ByVal heat_number As Long) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = " select w1 , w2 , w3 from mm_ladleweights where heat_number =" & CInt(heat_number)
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function

        Public Shared Function LadleWeightswdetails(ByVal heat_number As Long) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = " select w1 , w2 , w3 ,ladle_number,life from mm_ladleweights lw ,mm_ladle_details ld where lw.heat_number =ld.heat_number and lw.heat_number =" & CInt(heat_number)
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function

        Public Shared Function LadleWtempdetails(ByVal heat_number As Long) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = " select jmp_aluminium_star,heat_tapped,tap_time from mm_post_melt where heat_number=" & CInt(heat_number)
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function

        Public Shared Function LadleDetail(ByVal heat_number As Long) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = " select llt from mm_ladle_details where heat_number=" & CInt(heat_number)
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function

        Public Shared Function MouldTransList(ByVal TransDate As Date, ByVal Sh As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "mm_sp_MouldTransList"
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.Add("@TransDate", SqlDbType.SmallDateTime, 4).Value = TransDate
                da.SelectCommand.Parameters.Add("@Sh", SqlDbType.VarChar, 1).Value = Sh
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function CheckLadleWeights(ByVal heat_number As Long) As Boolean
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            oCmd.Parameters.Add("@cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output
            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.CommandText = "select @cnt = count(*) from mm_ladleweights where heat_number =  " & CInt(heat_number)
                oCmd.ExecuteScalar()
                CheckLadleWeights = IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value)
            Catch exp As Exception
                CheckLadleWeights = 0
                Throw New Exception(exp.Message)
            Finally
                If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
            End Try
        End Function
        Public Shared Function CheckMldNo(ByVal MldNo As String) As Boolean
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            oCmd.Parameters.Add("@cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output
            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.CommandText = "select @cnt = count(*) from mm_mould_master where mould_number =  '" & MldNo.Trim & "' "
                oCmd.ExecuteScalar()
                CheckMldNo = IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value)
            Catch exp As Exception
                CheckMldNo = 0
                Throw New Exception(exp.Message)
            Finally
                If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
            End Try
        End Function
        Public Shared Function GetMldDetails(ByVal MldNo As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = " select mld_typ , inglif , cpdglf , mld_sts from mm_mmmdmt_dump where mld_no =  @MldNo"
                da.SelectCommand.Parameters.Add("@MldNo", SqlDbType.VarChar, 50).Value = MldNo.Trim
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function MouldTransShiftData(ByVal TransDt As Date, ByVal Sh As String) As DataSet
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select row_number() over ( order by SlNo  ) Sl , " & _
                    " convert(varchar(11), TransDate,103) TransDate , Shift , LineJE , ShiftIC , TransName , " & _
                    " case when TransNo = 2 then '' else MPO end MPO , MouldNo , SlNo ," & _
                    " case when TransNo = 2 or TransNo = 4 then rtrim(ltrim(CodeDesc)) else '' end Defect , " & _
                    " case when convert(varchar(11),TransTime,103) = '01/01/1900' then '' else TransTime end TransTime" & _
                    " from mm_MouldTransaction a inner join mm_MouldTransactionType b on a.TransType = b.TransNo " & _
                    " left outer join mm_MouldTransactionTypeList on Defect = code " & _
                    " where TransDate = @TransDate and Shift = @Shift order by SlNo desc;" & _
                    " select convert(varchar(11),a.TransDate,103) TransDate , a.Shift , Status , MouldType , " & _
                    " ( a.Cope + isnull(b.Cope,0) ) Cope , " & _
                    " ( a.Drag + isnull(b.Drag,0) ) Drag  from " & _
                    " ( select * from mm_vw_MouldPosition a " & _
                    " where TransDate = @TransDate and Shift = @Shift " & _
                    " and Status <> 'OnLINE' ) a " & _
                    " left outer join " & _
                    " ( select TransDate , Shift , MPO , WhlType , " & _
                    " sum(case when TransNo in ( 3 , 4 ) then cope else 0 end ) " & _
                    " - sum(case when TransNo in ( 1 ) then cope else 0 end ) Cope , " & _
                    " sum(case when TransNo in ( 3 , 4 ) then drag else 0 end ) " & _
                    " - sum(case when TransNo in ( 1 ) then drag else 0 end ) Drag" & _
                    " from mm_vw_MouldTransaction " & _
                    " where TransDate = @TransDate and Shift = @Shift " & _
                    " group by TransDate , Shift , MPO , WhlType ) b" & _
                    " on a.TransDate = b.TransDate  and a.Shift = b.Shift and MPO = Status" & _
                    " and WhlType = MouldType order by a.TransDate , a.Shift , Status , MouldType ;" & _
                    " select TransName , description WhlType , " & _
                    " sum(case when c.type = 'c' then 1 else 0 end) Cope , " & _
                    " sum(case when c.type = 'c' then 0 else 1 end) Drag   " & _
                    " from mm_MouldTransaction a inner join mm_MouldTransactionType b on a.TransType = b.TransNo " & _
                    " left outer join mm_mould_master c on MouldNo = mould_number" & _
                    " inner join mm_product_master d on d.product_code = c.product_code " & _
                    " where TransDate = @TransDate and Shift = @Shift " & _
                    " group by TransName , description order by TransName , description ;" & _
                    " select convert(varchar(11),a.TransDate,103) TransDate , a.Shift , Status , MouldType , " & _
                    " ( a.Cope + isnull(b.Cope,0 )) Cope ," & _
                    " ( a.Drag + isnull(b.Drag,0) ) Drag  from " & _
                    " ( select * from mm_vw_MouldPosition a " & _
                    " where TransDate = @TransDate and Shift = @Shift " & _
                    " and Status = 'OnLINE' ) a " & _
                    " left outer join ( " & _
                    " select TransDate , Shift , WhlType , " & _
                    " sum(case when TransNo in ( 1 ) then cope else 0 end ) " & _
                    " - sum(case when TransNo in ( 2,4  ) then cope else 0 end ) Cope , " & _
                    " sum(case when TransNo in ( 1) then drag else 0 end ) " & _
                    " - sum(case when TransNo in (  2,4 ) then drag else 0 end ) Drag" & _
                    " from mm_vw_MouldTransaction" & _
                    " where TransDate = @TransDate and Shift = @Shift " & _
                    " group by TransDate , Shift , WhlType ) b" & _
                    " on a.TransDate = b.TransDate  and a.Shift = b.Shift and WhlType = MouldType " & _
                    " order by a.TransDate , a.Shift , MouldType "
                da.SelectCommand.Parameters.Add("@TransDate", SqlDbType.SmallDateTime, 4).Value = CDate(TransDt)
                da.SelectCommand.Parameters.Add("@Shift", SqlDbType.VarChar, 1).Value = Sh.Trim
                da.Fill(ds)
                Return ds.Copy
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function OffloadCode() As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select code from mm_mmofrej_dump  where code not like '[0,1,2,3,4,5,6,7,8,9,x]%' ORDER BY CODE "
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function MouldOffloadData(ByVal OffloadDate As Date, ByVal HeatNumber As Long, ByVal OffloadCode As String) As DataSet
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select convert(varchar(11),OffloadDate,103) Dt ,  SIC , HeatNumber Ht , OffloadCode Code , OffloadCount Cnt " & _
                    " from mm_MROffLoad where HeatNumber = @HeatNumber order by OffloadCode ; " & _
                    " select OffloadCount from  mm_MROffLoad where HeatNumber = @HeatNumber and OffloadCode = @OffloadCode ; " & _
                    " select shift_supervisor from  mm_pre_pouring where Heat_Number = @HeatNumber ; " & _
                    " select HeatNumber , OffloadCode , OffloadCount , SIC " & _
                    " from  mm_MROffLoad where OffloadDate = @OffloadDate " & _
                    " order by HeatNumber , OffloadCode "
                da.SelectCommand.Parameters.Add("@OffloadDate", SqlDbType.SmallDateTime, 4).Value = CDate(OffloadDate)
                da.SelectCommand.Parameters.Add("@HeatNumber", SqlDbType.BigInt, 8).Value = HeatNumber
                da.SelectCommand.Parameters.Add("@OffloadCode", SqlDbType.VarChar, 10).Value = OffloadCode
                da.Fill(ds)
                Return ds.Copy
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function

        Public Shared Function MRHeatsTapped(ByVal DefectDate As Date) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.Parameters.Add("@Dt", SqlDbType.SmallDateTime, 4).Value = CDate(DefectDate)
                da.SelectCommand.CommandText = "select heat_number from mm_vw_HeatTapped " &
                " where Heat_Tapped between wap.dbo.mm_fn_GetShiftDateTime(@Dt, 'A', 0) and wap.dbo.mm_fn_GetShiftDateTime(@Dt, 'C', 1) " &
                " ORDER BY heat_number "
                '  da.SelectCommand.CommandText = "select heat_number=127056"
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function MRRunBackWheels(ByVal DefectDate As Date) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select heatNumber , WheelNumber , status ,  " & _
                    " PourOperator , PlungerPr , CentringRemarks , CTCOperator ,  " & _
                    " DomeDisc , PipeCondition, DTOperator, Remarks , " & _
                    " CloseDownRemarks , SeatingRemarks , TubeSinkRemarks ,  " & _
                    " PrgCraneRemarks , DragConditionRemarks , CopeConditionRemarks " & _
                    " from mm_MRRunBackWheels where RejDate = @RejDate "
                da.SelectCommand.Parameters.Add("@RejDate", SqlDbType.SmallDateTime, 4).Value = CDate(DefectDate)
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function MouldXCWheels(ByVal DefectDate As Date) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = " select a.heat_number Ht , a.wheel_number Whl , ltrim(rtrim(a.status)) Sts , pour_order PO ,  " & _
                 " PourOperator , PlungerPr , CentringRemarks , CTCOperator ,  " & _
                 " DomeDisc , PipeCondition, DTOperator, Remarks , drag_number , cope_number , " & _
                 " CloseDownRemarks , SeatingRemarks , TubeSinkRemarks , " & _
                 " PrgCraneRemarks , DragConditionRemarks, CopeConditionRemarks " & _
                 " from mm_wheel a left outer join mm_MRRunBackWheels b  " & _
                 " on heat_number = HeatNumber and WheelNumber =  wheel_number " & _
                 " inner join mm_vw_RunBackRunOutWheels c on c.heat_number = a.Heat_Number and c.Wheel_Number =  a.wheel_number " & _
                 " where DefectDate = @DefectDate "
                da.SelectCommand.Parameters.Add("@DefectDate", SqlDbType.SmallDateTime, 4).Value = CDate(DefectDate)
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function MRHeatPositionData(ByVal frHt As Long, ByVal toHt As Long) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "mm_sp_MRHeatPositionRevised"
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.CommandTimeout = 3600
                da.SelectCommand.Parameters.Add("@fr", SqlDbType.BigInt, 8).Value = CInt(frHt)
                da.SelectCommand.Parameters.Add("@to", SqlDbType.BigInt, 8).Value = CInt(toHt)
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function MouldPositionData() As DataSet
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select distinct rtrim(description) WhlType " & _
                    " from mm_mould_master c inner join mm_product_master d " & _
                    " on d.product_code = c.product_code order by rtrim(description) ;" & _
                    " select TransName , TransNo  from mm_MouldTransactionType ; "
                da.Fill(ds)
                Return ds.Copy
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function MROutTurnData(ByVal FrDt As Date, ByVal ToDt As Date) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select convert(varchar(11),OutTurnDate,103) OutTurnDate  , Shift , sum(WhlsCast) WhlsCast ,  " & _
                    "sum(MROffLoad) MROffLoad , sum(SW1Qty) SW1Qty , sum(SW2Qty) SW2Qty, sum(SW3Qty) SW3Qty,  " & _
                    "sum(SW4Qty) SW4Qty , sum(SW5Qty) SW5Qty, sum(SW6Qty) SW6Qty, sum(SW7Qty) SW7Qty,  " & _
                    "sum(SW8Qty) SW8Qty, sum(SGM1Qty) SGM1Qty, sum(SGM2Qty) SGM2Qty, sum(SGM3Qty) SGM3Qty ,  " & _
                    "sum(SGM4Qty) SGM4Qty, sum(HCM1Qty) HCM1Qty , sum(HCM2Qty) HCM2Qty, sum(HCM3Qty) HCM3Qty,  " & _
                    "sum(HCM4Qty) HCM4Qty , sum(HCM5Qty) HCM5Qty, sum(NFCQty) NFCQty, sum(NFDQty) NFDQty ,  " & _
                    "sum(DFDQty) DFDQty, sum(CBQty) CBQty, sum(CSQty) CSQty , sum(DSQty) DSQty,  " & _
                    "sum(COLQty) COLQty , sum(DOLQty) DOLQty , sum(SWCQty) SWCQty , sum(SWPGQty) SWPGQty , " & _
                    "sum(NBDQty) NBDQty , sum(DDUQty) DDUQty , " & _
                    "sum(CopesQty) CtoL , sum(DragsQty) DtoL , sum(SandQty) Sand , sum(PTQty) PTubes , " & _
                    "max(case when MPO1 = '1' then 'Yes' else 'No' end) MPO1 , " & _
                    "max(case when MPO2 = '1' then 'Yes' else 'No' end) MPO2 , " & _
                    "max(case when MPO3 = '1' then 'Yes' else 'No' end) MPO3  " & _
                    "from mm_MROutTurn " & _
                    "where OutTurnDate between @fr and @to " & _
                    "group by OutTurnDate , Shift " & _
                    "union " & _
                    "select '  '+convert(varchar(11),OutTurnDate,103) OutTurnDate  , 'ForAll' Shift , sum(WhlsCast) WhlsCast ,  " & _
                    "sum(MROffLoad) MROffLoad , sum(SW1Qty) SW1Qty , sum(SW2Qty) SW2Qty, sum(SW3Qty) SW3Qty,  " & _
                    "sum(SW4Qty) SW4Qty , sum(SW5Qty) SW5Qty, sum(SW6Qty) SW6Qty, sum(SW7Qty) SW7Qty,  " & _
                    "sum(SW8Qty) SW8Qty, sum(SGM1Qty) SGM1Qty, sum(SGM2Qty) SGM2Qty, sum(SGM3Qty) SGM3Qty ,  " & _
                    "sum(SGM4Qty) SGM4Qty, sum(HCM1Qty) HCM1Qty , sum(HCM2Qty) HCM2Qty, sum(HCM3Qty) HCM3Qty,  " & _
                    "sum(HCM4Qty) HCM4Qty , sum(HCM5Qty) HCM5Qty, sum(NFCQty) NFCQty, sum(NFDQty) NFDQty ,  " & _
                    "sum(DFDQty) DFDQty, sum(CBQty) CBQty, sum(CSQty) CSQty , sum(DSQty) DSQty,  " & _
                    "sum(COLQty) COLQty , sum(DOLQty) DOLQty , sum(SWCQty) SWC , sum(SWPGQty) SWPGC ," & _
                    "sum(NBDQty) NBDQty , sum(DDUQty) DDUQty , " & _
                    "sum(CopesQty) CtoL , sum(DragsQty) DtoL , sum(SandQty) Sand , sum(PTQty) PTubes , '' , '' , '' " & _
                    "from mm_MROutTurn " & _
                    "where OutTurnDate  between @fr and @to " & _
                    "group by OutTurnDate  " & _
                    "union " & _
                    "select 'Total' OutTurnDate , 'All' Shift , sum(WhlsCast) WhlsCast ,sum(MROffLoad) MROffLoad , sum(SW1Qty) SW1Qty , sum(SW2Qty) SW2Qty, sum(SW3Qty) SW3Qty,  " & _
                    "sum(SW4Qty) SW4Qty , sum(SW5Qty) SW5Qty, sum(SW6Qty) SW6Qty, sum(SW7Qty) SW7Qty,  " & _
                    "sum(SW8Qty) SW8Qty, sum(SGM1Qty) SGM1Qty, sum(SGM2Qty) SGM2Qty, sum(SGM3Qty) SGM3Qty ,  " & _
                    "sum(SGM4Qty) SGM4Qty, sum(HCM1Qty) HCM1Qty , sum(HCM2Qty) HCM2Qty, sum(HCM3Qty) HCM3Qty,  " & _
                    "sum(HCM4Qty) HCM4Qty , sum(HCM5Qty) HCM5Qty, sum(NFCQty) NFCQty, sum(NFDQty) NFDQty ,  " & _
                    "sum(DFDQty) DFDQty, sum(CBQty) CBQty, sum(CSQty) CSQty , sum(DSQty) DSQty,  " & _
                    "sum(COLQty) COLQty , sum(DOLQty) DOLQty , sum(SWCQty) SWC , sum(SWPGQty) SWPGC ," & _
                    "sum(NBDQty) NBDQty , sum(DDUQty) DDUQty , " & _
                    "sum(CopesQty) CtoL , sum(DragsQty) DtoL , sum(SandQty) Sand , sum(PTQty) PTubes , '' , '' , '' " & _
                    "from mm_MROutTurn " & _
                    "where OutTurnDate  between @fr and @to "
                da.SelectCommand.Parameters.Add("@fr", SqlDbType.SmallDateTime, 4).Value = CDate(FrDt)
                da.SelectCommand.Parameters.Add("@to", SqlDbType.SmallDateTime, 4).Value = CDate(ToDt)
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function MROutTurnData(ByVal OutTurnDate As Date, ByVal Shift As String) As DataSet
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select wap.dbo.mm_fn_CastWheelsForShift(OutTurnDate,Shift) WhlsCast , *  from mm_MROutTurn where OutTurnDate  = @OutTurnDate and Shift = @Shift "
                da.SelectCommand.Parameters.Add("@OutTurnDate", SqlDbType.SmallDateTime, 4).Value = CDate(OutTurnDate)
                da.SelectCommand.Parameters.Add("@Shift", SqlDbType.VarChar, 1).Value = Shift
                da.Fill(ds)
                Return ds.Copy
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function MROutTurn(ByVal OutTurnDate As Date, ByVal Shift As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select convert(varchar(11),OutTurnDate,103) OutTurnDate  , Shift , sum(WhlsCast) WhlsCast ,  " & _
                "sum(MROffLoad) MROffLoad , sum(SW1Qty) SW1 , sum(SW2Qty) SW2, sum(SW3Qty) SW3,  " & _
                "sum(SW4Qty) SW4 , sum(SW5Qty) SW5, sum(SW6Qty) SW6, sum(SW7Qty) SW7,  " & _
                "sum(SW8Qty) SW8, sum(SGM1Qty) SGM1, sum(SGM2Qty) SGM2, sum(SGM3Qty) SGM3 ,  " & _
                "sum(SGM4Qty) SGM4, sum(HCM1Qty) HCM1 , sum(HCM2Qty) HCM2, sum(HCM3Qty) HCM3,  " & _
                "sum(HCM4Qty) HCM4 , sum(HCM5Qty) HCM5, sum(NFCQty) NFC, sum(NFDQty) NFD ,  " & _
                "sum(DFDQty) DFD, sum(CBQty) CB, sum(CSQty) CS , sum(DSQty) DS,  " & _
                "sum(COLQty) COL , sum(DOLQty) DOL , sum(SWCQty) SWC , sum(SWPGQty) SWPGC , " & _
                "sum(NBDQty) NBDQty , sum(DDUQty) DDUQty , " & _
                "sum(CopesQty) CtoL , sum(DragsQty) DtoL , sum(SandQty) Sand , sum(PTQty) PTubes ," & _
                "max(case when MPO1 = '1' then 'Yes' else 'No' end) MPO1 , " & _
                "max(case when MPO2 = '1' then 'Yes' else 'No' end) MPO2 , " & _
                "max(case when MPO3 = '1' then 'Yes' else 'No' end) MPO3 , " & _
                "sum(BucketsQty) BucketsQty  , max(BucketsInC) BucketsInC , max(BucketsRemarks) BucketsRemarks " & _
                "from mm_MROutTurn " & _
                "where month(OutTurnDate)  = month(@OutTurnDate) and year(OutTurnDate) = year(@OutTurnDate) " & _
                "and OutTurnDate <= @OutTurnDate " & _
                "group by OutTurnDate , Shift " & _
                "union " & _
                "select '  '+convert(varchar(11),OutTurnDate,103) OutTurnDate  , 'ForAll' Shift , sum(WhlsCast) WhlsCast ,  " & _
                "sum(MROffLoad) MROffLoad , sum(SW1Qty) SW1Qty , sum(SW2Qty) SW2Qty, sum(SW3Qty) SW3Qty,  " & _
                "sum(SW4Qty) SW4Qty , sum(SW5Qty) SW5Qty, sum(SW6Qty) SW6Qty, sum(SW7Qty) SW7Qty,  " & _
                "sum(SW8Qty) SW8Qty, sum(SGM1Qty) SGM1Qty, sum(SGM2Qty) SGM2Qty, sum(SGM3Qty) SGM3Qty ,  " & _
                "sum(SGM4Qty) SGM4Qty, sum(HCM1Qty) HCM1Qty , sum(HCM2Qty) HCM2Qty, sum(HCM3Qty) HCM3Qty,  " & _
                "sum(HCM4Qty) HCM4Qty , sum(HCM5Qty) HCM5Qty, sum(NFCQty) NFCQty, sum(NFDQty) NFDQty ,  " & _
                "sum(DFDQty) DFDQty, sum(CBQty) CBQty, sum(CSQty) CSQty , sum(DSQty) DSQty,  " & _
                "sum(COLQty)/3 COLQty , sum(DOLQty)/3 DOLQty ,  sum(SWCQty) SWC , sum(SWPGQty) SWPGC ,  " & _
                "sum(NBDQty) NBDQty , sum(DDUQty) DDUQty , " & _
                "sum(CopesQty) CtoL , sum(DragsQty) DtoL , sum(SandQty) Sand , sum(PTQty) PTubes , '' , '' , '' , sum(BucketsQty) BucketsQty  , '' , '' " & _
                "from mm_MROutTurn " & _
                "where month(OutTurnDate)  = month(@OutTurnDate) and year(OutTurnDate) = year(@OutTurnDate) " & _
                "and OutTurnDate <= @OutTurnDate " & _
                "group by OutTurnDate  " & _
                "union " & _
                "select 'Total' OutTurnDate , 'All' Shift , sum(WhlsCast) WhlsCast ,sum(MROffLoad) MROffLoad , sum(SW1Qty) SW1Qty , sum(SW2Qty) SW2Qty, sum(SW3Qty) SW3Qty,  " & _
                "sum(SW4Qty) SW4Qty , sum(SW5Qty) SW5Qty, sum(SW6Qty) SW6Qty, sum(SW7Qty) SW7Qty,  " & _
                "sum(SW8Qty) SW8Qty, sum(SGM1Qty) SGM1Qty, sum(SGM2Qty) SGM2Qty, sum(SGM3Qty) SGM3Qty ,  " & _
                "sum(SGM4Qty) SGM4Qty, sum(HCM1Qty) HCM1Qty , sum(HCM2Qty) HCM2Qty, sum(HCM3Qty) HCM3Qty,  " & _
                "sum(HCM4Qty) HCM4Qty , sum(HCM5Qty) HCM5Qty, sum(NFCQty) NFCQty, sum(NFDQty) NFDQty ,  " & _
                "sum(DFDQty) DFDQty, sum(CBQty) CBQty, sum(CSQty) CSQty , sum(DSQty) DSQty,  " & _
                "sum(COLQty)/count(*) COLQty , sum(DOLQty)/count(*) DOLQty ,  sum(SWCQty) SWC , sum(SWPGQty) SWPGC ,  " & _
                "sum(NBDQty) NBDQty , sum(DDUQty) DDUQty , " & _
                "sum(CopesQty) CtoL , sum(DragsQty) DtoL , sum(SandQty) Sand , sum(PTQty) PTubes , '' , '' , '' , sum(BucketsQty) BucketsQty  , '' , '' " & _
                "from mm_MROutTurn " & _
                "where month(OutTurnDate)  = month(@OutTurnDate) and year(OutTurnDate) = year(@OutTurnDate) " & _
                "and OutTurnDate <= @OutTurnDate "
                da.SelectCommand.Parameters.Add("@OutTurnDate", SqlDbType.SmallDateTime, 4).Value = CDate(OutTurnDate)
                da.SelectCommand.Parameters.Add("@Shift", SqlDbType.VarChar, 1).Value = Shift
                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function MouldTrans(ByVal FromDate As Date, ByVal ToDate As Date, ByVal Type As Integer, ByVal MouldNo As String) As DataTable
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                'If MouldNo.Trim.Length = 0 Then
                '    da.SelectCommand.CommandText = "select TransDt , Shift , MouldNo , " & _
                '        " WhlType , CodeDesc , TransName , Type , " & _
                '        " MachiningDt , IntialHt , FinalHt , WhlCast , Remarks , " & _
                '        " wap.dbo.mm_fn_MouldSoakTime(SlNo)  SoakTime , TransTime " & _
                '        " from mm_vw_MouldTransactions " & _
                '        " where TransDate between @FrDt and @ToDt " & _
                '        " and TransType = @TransType order by TransDate , Shift  "
                '    da.SelectCommand.Parameters.Add("@FrDt", SqlDbType.SmallDateTime, 4).Value = CDate(FromDate)
                '    da.SelectCommand.Parameters.Add("@ToDt", SqlDbType.SmallDateTime, 4).Value = CDate(ToDate)
                '    da.SelectCommand.Parameters.Add("@TransType", SqlDbType.Int, 4).Value = Type
                'Else
                '    da.SelectCommand.CommandText = "select TransDt , Shift , MouldNo , " & _
                '        " WhlType , CodeDesc , TransName , Type , " & _
                '        " MachiningDt , IntialHt , FinalHt , WhlCast , Remarks , wap.dbo.mm_fn_MouldSoakTime(SlNo)  SoakTime " & _
                '        " from mm_vw_MouldTransactions " & _
                '        " where MouldNo = @MouldNo order by TransDate , Shift "
                '    da.SelectCommand.Parameters.Add("@MouldNo", SqlDbType.VarChar, 50).Value = MouldNo
                'End If
                da.SelectCommand.CommandText = "mm_sp_MouldTransaction"
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.Add("@FrDt", SqlDbType.SmallDateTime, 4).Value = CDate(FromDate)
                da.SelectCommand.Parameters.Add("@ToDt", SqlDbType.SmallDateTime, 4).Value = CDate(ToDate)
                da.SelectCommand.Parameters.Add("@TransType", SqlDbType.Int, 4).Value = Type
                da.SelectCommand.Parameters.Add("@MouldNo", SqlDbType.VarChar, 50).Value = MouldNo
                da.Fill(ds)
                Return ds.Tables(0).Copy
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function MouldPosition(ByVal TransDate As Date, ByVal Shift As String, ByVal Status As String, ByVal Type As String, ByVal MouldType As String) As DataSet
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select Status , Type , MouldType , Value , SlNo " & _
                    " from mm_MouldPosition " & _
                    " where TransDate = @TransDate and Shift = @Shift order by SlNo desc;" & _
                    " select Value ,  SlNo from mm_MouldPosition " & _
                    " where TransDate = @TransDate and Shift = @Shift and Type = @Type " & _
                    " and MouldType = @MouldType and Status = @Status ;" & _
                    " select Status ,  MouldType , Cope , Drag from mm_vw_MouldPosition " & _
                    " where TransDate = @TransDate and Shift = @Shift " & _
                    " order by TransDate , Shift , Status ,  MouldType "
                da.SelectCommand.Parameters.Add("@TransDate", SqlDbType.SmallDateTime, 4).Value = CDate(TransDate)
                da.SelectCommand.Parameters.Add("@Shift", SqlDbType.VarChar, 1).Value = Shift
                da.SelectCommand.Parameters.Add("@Status", SqlDbType.VarChar, 10).Value = Status
                da.SelectCommand.Parameters.Add("@Type", SqlDbType.VarChar, 1).Value = Type
                da.SelectCommand.Parameters.Add("@MouldType", SqlDbType.VarChar, 50).Value = MouldType
                da.Fill(ds)
                Return ds.Copy
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function MouldTransData() As DataSet
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select machine_code , description  from ms_machinery_master " &
                    " where location_code = 'mo' and machine_code like 'mompo%' order by machine_code ;" &
                    " select TransName , TransNo  from mm_MouldTransactionType ; " &
                    " select CodeDesc , Code from mm_vw_MouldTransactionTypeList order by CodeDesc "
                da.Fill(ds)
                Return ds.Copy
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Shared Function MRHeatDetails(ByVal Heat As Integer) As DataSet
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select * from wap.dbo.mm_fn_MRHeatDetails(@fr,@to,'','',0); " & _
                    " select convert(varchar(10),MPILTime,103) MPILDate , " & _
                    " convert(varchar(2),MPILTime,108) MPILHr , " & _
                    " substring(convert(varchar(5),MPILTime,108),4,2) MPILMn , " & _
                    " Remarks1 , Remarks2 , Remarks3 , RunOuts , RunBacks from mm_MRHeatPosition where heat = @fr "
                da.SelectCommand.Parameters.Add("@fr", SqlDbType.BigInt, 8).Value = CInt(Heat)
                da.SelectCommand.Parameters.Add("@to", SqlDbType.BigInt, 8).Value = CInt(Heat)
                da.Fill(ds)
                Return ds.Copy
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        'Public Function SaveMouldTran(ByVal TransDt As Date, ByVal Sh As String, ByVal LineJE As String, ByVal ShiftIC As String, ByVal MldType As Integer, ByVal MpoList As String, ByVal MouldNo As String, ByVal Defect As Integer, ByVal TransTime As DateTime) As Boolean
        '    Dim oCmd As New SqlClient.SqlCommand()
        '    oCmd.Connection = rwfGen.Connection.ConObj
        '    Dim done As New Boolean()
        '    Try
        '        If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
        '        oCmd.CommandText = "insert into mm_MouldTransaction " & _
        '            " ( TransDate , Shift , LineJE , ShiftIC , TransType , MPO , MouldNo , Defect , TransTime ) " & _
        '            " values ( @TransDate , @Shift , @LineJE , @ShiftIC , @TransType , @MPO , @MouldNo , @Defect , @TransTime ) "
        '        oCmd.Parameters.Add("@TransDate", SqlDbType.SmallDateTime, 4).Value = CDate(TransDt)
        '        oCmd.Parameters.Add("@Shift", SqlDbType.VarChar, 1).Value = Sh.Trim
        '        oCmd.Parameters.Add("@LineJE", SqlDbType.VarChar, 50).Value = LineJE
        '        oCmd.Parameters.Add("@ShiftIC", SqlDbType.VarChar, 50).Value = ShiftIC
        '        oCmd.Parameters.Add("@TransType", SqlDbType.Int, 4).Value = MldType
        '        oCmd.Parameters.Add("@MPO", SqlDbType.VarChar, 50).Value = MpoList
        '        oCmd.Parameters.Add("@MouldNo", SqlDbType.VarChar, 50).Value = MouldNo
        '        oCmd.Parameters.Add("@TransTime", SqlDbType.DateTime, 8).Direction = ParameterDirection.Input
        '        oCmd.Parameters.Add("@Defect", SqlDbType.Int, 4).Value = Defect
        '        oCmd.Parameters("@TransTime").Value = TransTime
        '        If oCmd.ExecuteNonQuery > 0 Then done = True
        '    Catch exp As Exception
        '        done = False
        '        Throw New Exception(exp.Message)
        '    Finally
        '        If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
        '        oCmd.Dispose()
        '        oCmd = Nothing
        '    End Try
        '    Return done
        'End Function

        Public Function SaveMouldTran(ByVal TransDt As Date, ByVal Sh As String, ByVal LineJE As String, ByVal ShiftIC As String, ByVal MldType As Integer, ByVal MpoList As String, ByVal MouldNo As String, ByVal Defect As Integer, ByVal TransTime As DateTime, ByVal AddAfterMouldNo As String) As Boolean
            Dim oCmd As New SqlClient.SqlCommand()
            oCmd.Connection = rwfGen.Connection.ConObj
            Dim done As New Boolean()
            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.CommandText = "insert into mm_MouldTransactionNew " &
                    " ( TransDate , Shift , LineJE , ShiftIC , TransType , MPO , MouldNo , Defect , TransTime,AddAfterMouldNo ) " &
                    " values ( @TransDate , @Shift , @LineJE , @ShiftIC , @TransType , @MPO , @MouldNo , @Defect , @TransTime, @AddAfterMouldNo ) "
                oCmd.Parameters.Add("@TransDate", SqlDbType.SmallDateTime, 4).Value = CDate(TransDt)
                oCmd.Parameters.Add("@Shift", SqlDbType.VarChar, 1).Value = Sh.Trim
                oCmd.Parameters.Add("@LineJE", SqlDbType.VarChar, 50).Value = LineJE
                oCmd.Parameters.Add("@ShiftIC", SqlDbType.VarChar, 50).Value = ShiftIC
                oCmd.Parameters.Add("@TransType", SqlDbType.Int, 4).Value = MldType
                oCmd.Parameters.Add("@MPO", SqlDbType.VarChar, 50).Value = MpoList
                oCmd.Parameters.Add("@MouldNo", SqlDbType.VarChar, 50).Value = MouldNo
                oCmd.Parameters.Add("@TransTime", SqlDbType.DateTime, 8).Direction = ParameterDirection.Input
                oCmd.Parameters.Add("@Defect", SqlDbType.Int, 4).Value = Defect
                oCmd.Parameters("@TransTime").Value = TransTime
                oCmd.Parameters.Add("@AddAfterMouldNo", SqlDbType.VarChar, 50).Value = AddAfterMouldNo
                If oCmd.ExecuteNonQuery > 0 Then done = True
            Catch exp As Exception
                done = False
                Throw New Exception(exp.Message)
            Finally
                If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
            End Try
            Return done
        End Function
        Public Function MouldPositionAdd(ByVal TransDt As Date, ByVal Sh As String, ByVal Status As String, ByVal Type As String, ByVal MouldType As String, ByVal Value As Integer) As Boolean
            Dim oCmd As New SqlClient.SqlCommand()
            oCmd.Connection = rwfGen.Connection.ConObj
            Dim done As New Boolean()
            Try
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.Parameters.Add("@TransDate", SqlDbType.SmallDateTime, 4).Value = CDate(TransDt)
                oCmd.Parameters.Add("@Shift", SqlDbType.VarChar, 1).Value = Sh
                oCmd.Parameters.Add("@Status", SqlDbType.VarChar, 50).Value = Status
                oCmd.Parameters.Add("@Type", SqlDbType.VarChar, 1).Value = Type
                oCmd.Parameters.Add("@MouldType", SqlDbType.VarChar, 50).Value = MouldType
                oCmd.Parameters.Add("@Value", SqlDbType.Int, 4).Value = Value
                oCmd.Parameters.Add("@SlNo", SqlDbType.Int, 4).Direction = ParameterDirection.Output

                oCmd.CommandText = " select @SlNo = SlNo from mm_MouldPosition where TransDate =  @TransDate " & _
                    " and Shift = @Shift and Status = @Status and Type = @Type and MouldType = @MouldType "
                oCmd.ExecuteScalar()
                If IIf(IsDBNull(oCmd.Parameters("@SlNo").Value), 0, oCmd.Parameters("@SlNo").Value) = 0 Then
                    oCmd.CommandText = " insert into mm_MouldPosition " & _
                    " ( TransDate , Shift , Status , Type , MouldType , Value ) values " & _
                    " ( @TransDate , @Shift , @Status , @Type , @MouldType , @Value ) "
                Else
                    oCmd.CommandText = " update mm_MouldPosition  set Value = @Value" & _
                        " where TransDate =  @TransDate and Shift = @Shift and Status = @Status " & _
                        " and Type = @Type and MouldType = @MouldType and @SlNo = SlNo "
                End If
                If oCmd.ExecuteNonQuery > 0 Then done = True
            Catch exp As Exception
                done = False
                Throw New Exception(exp.Message)
            Finally
                If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                oCmd.Dispose()
                oCmd = Nothing
            End Try
            Return done
        End Function
        Public Function DeleteMouldPosition(ByVal SlNo As Long) As Boolean
            Dim Done As Boolean
            Try
                Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.Parameters.Add("@SlNo", SqlDbType.Int, 4).Value = SlNo
                Try
                    oCmd.CommandText = " delete mm_MouldPosition where SlNo  = @SlNo "
                    oCmd.Transaction = oCmd.Connection.BeginTransaction
                    Try
                        If oCmd.ExecuteNonQuery = 1 Then
                            Done = True
                        End If
                    Catch exp As Exception
                        Throw New Exception(" Deletion of Mould Position failed !" & exp.Message)
                    End Try
                Catch exp As Exception
                    Throw New Exception(exp.Message)
                Finally
                    If Not IsNothing(oCmd) Then
                        If Done Then
                            oCmd.Transaction.Commit()
                        Else
                            oCmd.Transaction.Rollback()
                        End If
                        If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                        oCmd.Dispose()
                        oCmd = Nothing
                    End If
                End Try
                Done = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
                Done = False
            End Try
            Return Done
        End Function

        Public Function MRRunBackWheelsAdd(ByVal RejDate As Date, ByVal Heat As Long, ByVal Wheel As Long, ByVal Status As String, ByVal PourOperator As String, ByVal PlungerPr As String, ByVal CentringRemarks As String, ByVal CTCOperator As String, ByVal DomeDisc As String, ByVal PipeCondition As String, ByVal DTOperator As String, ByVal Remarks As String, ByVal CloseDownRemarks As String, ByVal SeatingRemarks As String, ByVal TubeSinkRemarks As String, ByVal PrgCraneRemarks As String, ByVal DragConditionRemarks As String, ByVal CopeConditionRemarks As String, ByVal IngateReamerOperator As String) As Boolean
            Dim Done As Boolean
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            Dim strInsert, strUpdate As String
            Try
                oCmd.Parameters.Add("@HeatNumber", SqlDbType.BigInt, 8).Value = Heat
                oCmd.Parameters.Add("@WheelNumber", SqlDbType.BigInt, 8).Value = Wheel
                oCmd.Parameters.Add("@RejDate", SqlDbType.SmallDateTime, 4).Value = CDate(RejDate)
                oCmd.Parameters.Add("@Status", SqlDbType.VarChar, 50).Value = Status.Trim
                oCmd.Parameters.Add("@PourOperator", SqlDbType.VarChar, 50).Value = PourOperator.Trim
                oCmd.Parameters.Add("@PlungerPr", SqlDbType.VarChar, 50).Value = PlungerPr.Trim
                oCmd.Parameters.Add("@CentringRemarks", SqlDbType.VarChar, 50).Value = CentringRemarks.Trim
                oCmd.Parameters.Add("@CTCOperator", SqlDbType.VarChar, 50).Value = CTCOperator.Trim
                oCmd.Parameters.Add("@DomeDisc", SqlDbType.VarChar, 1).Value = DomeDisc.Trim
                oCmd.Parameters.Add("@PipeCondition", SqlDbType.VarChar, 50).Value = PipeCondition.Trim
                oCmd.Parameters.Add("@DTOperator", SqlDbType.VarChar, 50).Value = DTOperator.Trim
                oCmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 50).Value = Remarks.Trim
                oCmd.Parameters.Add("@CloseDownRemarks", SqlDbType.VarChar, 50).Value = CloseDownRemarks.Trim
                oCmd.Parameters.Add("@SeatingRemarks", SqlDbType.VarChar, 50).Value = SeatingRemarks.Trim
                oCmd.Parameters.Add("@TubeSinkRemarks", SqlDbType.VarChar, 50).Value = TubeSinkRemarks.Trim
                oCmd.Parameters.Add("@PrgCraneRemarks", SqlDbType.VarChar, 50).Value = PrgCraneRemarks.Trim
                oCmd.Parameters.Add("@DragConditionRemarks", SqlDbType.VarChar, 50).Value = DragConditionRemarks.Trim
                oCmd.Parameters.Add("@CopeConditionRemarks", SqlDbType.VarChar, 50).Value = CopeConditionRemarks.Trim
                oCmd.Parameters.Add("@IngateReamerOperator", SqlDbType.VarChar, 50).Value = IngateReamerOperator.Trim

                oCmd.Parameters.Add("@cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output

                strInsert = " insert into mm_MRRunBackWheelsNew ( heatNumber , WheelNumber , status , PourOperator , " &
                    " CloseDownRemarks , SeatingRemarks , TubeSinkRemarks , PrgCraneRemarks , DragConditionRemarks , CopeConditionRemarks , " &
                    " PlungerPr , CentringRemarks , CTCOperator , DomeDisc , PipeCondition ,  DTOperator , Remarks  , RejDate,IngateReamerOperator ) " &
                    " values ( @heatNumber , @WheelNumber , @status , @PourOperator , " &
                    " @CloseDownRemarks , @SeatingRemarks , @TubeSinkRemarks , @PrgCraneRemarks , @DragConditionRemarks , @CopeConditionRemarks ," &
                    " @PlungerPr , @CentringRemarks , @CTCOperator , @DomeDisc , @PipeCondition ,  @DTOperator , @Remarks , @RejDate,@IngateReamerOperator
)  "

                strUpdate = " update mm_MRRunBackWheelsNew set Status = @status , PourOperator = @PourOperator , PlungerPr = @PlungerPr ,  " &
                    " CentringRemarks = @CentringRemarks , CTCOperator = @CTCOperator , DomeDisc = @DomeDisc ,  " &
                    " PipeCondition = @PipeCondition ,  DTOperator = @DTOperator , Remarks = @Remarks ,IngateReamerOperator=@IngateReamerOperator " &
                    " CloseDownRemarks = @CloseDownRemarks , SeatingRemarks = @SeatingRemarks , TubeSinkRemarks = @TubeSinkRemarks , " &
                    " PrgCraneRemarks = @PrgCraneRemarks , DragConditionRemarks = @DragConditionRemarks , CopeConditionRemarks = @CopeConditionRemarks " &
                    " where HeatNumber = @heatNumber and WheelNumber =  @WheelNumber and RejDate = @RejDate "

                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.Transaction = oCmd.Connection.BeginTransaction
                oCmd.CommandText = "select @cnt = count(*)  from mm_MRRunBackWheelsNew where RejDate = @RejDate and heatNumber = @heatNumber and WheelNumber = @WheelNumber "
                oCmd.ExecuteScalar()
                If IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value) = 0 Then
                    oCmd.CommandText = strInsert
                Else
                    oCmd.CommandText = strUpdate
                End If
                If oCmd.ExecuteNonQuery = 1 Then Done = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If Not IsNothing(oCmd) Then
                    If Done Then
                        oCmd.Transaction.Commit()
                    Else
                        oCmd.Transaction.Rollback()
                    End If
                    If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                    oCmd.Dispose()
                    oCmd = Nothing
                End If
            End Try
            strInsert = Nothing
            strUpdate = Nothing
            Return Done
        End Function
        'Public Function MRRunBackWheelsAdd(ByVal RejDate As Date, ByVal Heat As Long, ByVal Wheel As Long, ByVal Status As String, ByVal PourOperator As String, ByVal PlungerPr As String, ByVal CentringRemarks As String, ByVal CTCOperator As String, ByVal DomeDisc As String, ByVal PipeCondition As String, ByVal DTOperator As String, ByVal Remarks As String, ByVal CloseDownRemarks As String, ByVal SeatingRemarks As String, ByVal TubeSinkRemarks As String, ByVal PrgCraneRemarks As String, ByVal DragConditionRemarks As String, ByVal CopeConditionRemarks As String) As Boolean
        '    Dim Done As Boolean
        '    Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
        '    Dim strInsert, strUpdate As String
        '    Try
        '        oCmd.Parameters.Add("@HeatNumber", SqlDbType.BigInt, 8).Value = Heat
        '        oCmd.Parameters.Add("@WheelNumber", SqlDbType.BigInt, 8).Value = Wheel
        '        oCmd.Parameters.Add("@RejDate", SqlDbType.SmallDateTime, 4).Value = CDate(RejDate)
        '        oCmd.Parameters.Add("@Status", SqlDbType.VarChar, 50).Value = Status.Trim
        '        oCmd.Parameters.Add("@PourOperator", SqlDbType.VarChar, 50).Value = PourOperator.Trim
        '        oCmd.Parameters.Add("@PlungerPr", SqlDbType.VarChar, 50).Value = PlungerPr.Trim
        '        oCmd.Parameters.Add("@CentringRemarks", SqlDbType.VarChar, 50).Value = CentringRemarks.Trim
        '        oCmd.Parameters.Add("@CTCOperator", SqlDbType.VarChar, 50).Value = CTCOperator.Trim
        '        oCmd.Parameters.Add("@DomeDisc", SqlDbType.VarChar, 1).Value = DomeDisc.Trim
        '        oCmd.Parameters.Add("@PipeCondition", SqlDbType.VarChar, 50).Value = PipeCondition.Trim
        '        oCmd.Parameters.Add("@DTOperator", SqlDbType.VarChar, 50).Value = DTOperator.Trim
        '        oCmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 50).Value = Remarks.Trim
        '        oCmd.Parameters.Add("@CloseDownRemarks", SqlDbType.VarChar, 50).Value = CloseDownRemarks.Trim
        '        oCmd.Parameters.Add("@SeatingRemarks", SqlDbType.VarChar, 50).Value = SeatingRemarks.Trim
        '        oCmd.Parameters.Add("@TubeSinkRemarks", SqlDbType.VarChar, 50).Value = TubeSinkRemarks.Trim
        '        oCmd.Parameters.Add("@PrgCraneRemarks", SqlDbType.VarChar, 50).Value = PrgCraneRemarks.Trim
        '        oCmd.Parameters.Add("@DragConditionRemarks", SqlDbType.VarChar, 50).Value = DragConditionRemarks.Trim
        '        oCmd.Parameters.Add("@CopeConditionRemarks", SqlDbType.VarChar, 50).Value = CopeConditionRemarks.Trim

        '        oCmd.Parameters.Add("@cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output

        '        strInsert = " insert into mm_MRRunBackWheels ( heatNumber , WheelNumber , status , PourOperator , " & _
        '            " CloseDownRemarks , SeatingRemarks , TubeSinkRemarks , PrgCraneRemarks , DragConditionRemarks , CopeConditionRemarks , " & _
        '            " PlungerPr , CentringRemarks , CTCOperator , DomeDisc , PipeCondition ,  DTOperator , Remarks  , RejDate ) " & _
        '            " values ( @heatNumber , @WheelNumber , @status , @PourOperator , " & _
        '            " @CloseDownRemarks , @SeatingRemarks , @TubeSinkRemarks , @PrgCraneRemarks , @DragConditionRemarks , @CopeConditionRemarks ," & _
        '            " @PlungerPr , @CentringRemarks , @CTCOperator , @DomeDisc , @PipeCondition ,  @DTOperator , @Remarks , @RejDate  )  "

        '        strUpdate = " update mm_MRRunBackWheels set Status = @status , PourOperator = @PourOperator , PlungerPr = @PlungerPr ,  " & _
        '            " CentringRemarks = @CentringRemarks , CTCOperator = @CTCOperator , DomeDisc = @DomeDisc ,  " & _
        '            " PipeCondition = @PipeCondition ,  DTOperator = @DTOperator , Remarks = @Remarks , " & _
        '            " CloseDownRemarks = @CloseDownRemarks , SeatingRemarks = @SeatingRemarks , TubeSinkRemarks = @TubeSinkRemarks , " & _
        '            " PrgCraneRemarks = @PrgCraneRemarks , DragConditionRemarks = @DragConditionRemarks , CopeConditionRemarks = @CopeConditionRemarks " & _
        '            " where HeatNumber = @heatNumber and WheelNumber =  @WheelNumber and RejDate = @RejDate "

        '        If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
        '        oCmd.Transaction = oCmd.Connection.BeginTransaction
        '        oCmd.CommandText = "select @cnt = count(*)  from mm_MRRunBackWheels where RejDate = @RejDate and heatNumber = @heatNumber and WheelNumber = @WheelNumber "
        '        oCmd.ExecuteScalar()
        '        If IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value) = 0 Then
        '            oCmd.CommandText = strInsert
        '        Else
        '            oCmd.CommandText = strUpdate
        '        End If
        '        If oCmd.ExecuteNonQuery = 1 Then Done = True
        '    Catch exp As Exception
        '        Throw New Exception(exp.Message)
        '    Finally
        '        If Not IsNothing(oCmd) Then
        '            If Done Then
        '                oCmd.Transaction.Commit()
        '            Else
        '                oCmd.Transaction.Rollback()
        '            End If
        '            If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
        '            oCmd.Dispose()
        '            oCmd = Nothing
        '        End If
        '    End Try
        '    strInsert = Nothing
        '    strUpdate = Nothing
        '    Return Done
        'End Function
        Public Function MROffloadAdd(ByVal HeatNumber As Long, ByVal OffloadCode As String, ByVal OffloadDate As Date, ByVal SIC As String, ByVal OffloadCount As Integer) As Boolean
            Dim Done As Boolean
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            Dim strInsert, strUpdate As String

            Try
                oCmd.Parameters.Add("@OffloadDate", SqlDbType.SmallDateTime, 4).Value = CDate(OffloadDate)
                oCmd.Parameters.Add("@SIC", SqlDbType.VarChar, 10).Value = SIC.Trim & ""
                oCmd.Parameters.Add("@HeatNumber", SqlDbType.BigInt, 8).Value = HeatNumber
                oCmd.Parameters.Add("@OffloadCode", SqlDbType.VarChar, 10).Value = OffloadCode
                oCmd.Parameters.Add("@OffloadCount", SqlDbType.Int, 4).Value = Val(OffloadCount)
                oCmd.Parameters.Add("@cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output
                strInsert = " insert into mm_MROffLoad ( OffloadDate , SIC , HeatNumber , OffloadCode , OffloadCount  ) values ( @OffloadDate , @SIC , @HeatNumber , @OffloadCode , @OffloadCount  )  "

                strUpdate = " update mm_MROffLoad set OffloadCount = @OffloadCount where HeatNumber = @HeatNumber and OffloadCode = @OffloadCode "

                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.Transaction = oCmd.Connection.BeginTransaction
                oCmd.CommandText = "select @cnt = count(*)  from mm_MROffLoad where HeatNumber  = @HeatNumber and OffloadCode = @OffloadCode "
                oCmd.ExecuteScalar()
                If IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value) = 0 Then
                    oCmd.CommandText = strInsert
                Else
                    oCmd.CommandText = strUpdate
                End If
                If oCmd.ExecuteNonQuery = 1 Then Done = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If Not IsNothing(oCmd) Then
                    If Done Then
                        oCmd.Transaction.Commit()
                    Else
                        oCmd.Transaction.Rollback()
                    End If
                    If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                    oCmd.Dispose()
                    oCmd = Nothing
                    strInsert = Nothing
                    strUpdate = Nothing
                End If
            End Try
            Return Done
        End Function

        'Public Function SaveMRHeatPosition(ByVal str As String, ByVal Heat As Long, ByVal Remarks1 As String, ByVal Remarks2 As String, ByVal Remarks3 As String, ByVal RunOuts As Integer, ByVal RunBacks As Integer) As Boolean
        '    Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
        '    Dim strInsert, strUpdate As String
        '    Dim Done As Boolean
        '    Try
        '        oCmd.Parameters.Add("@heat", SqlDbType.BigInt, 8).Value = CLng(Heat)
        '        oCmd.Parameters.Add("@cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output

        '        strInsert = " insert into mm_MRHeatPosition ( Heat , Remarks1 , Remarks2 , Remarks3 , MPILTime , RunOuts , RunBacks )" & _
        '         " values ( @Heat , @Remarks1 , @Remarks2 , @Remarks3 , @MPILTime , @RunOuts , @RunBacks )"


        '        strUpdate = " update mm_MRHeatPosition set Remarks1 = @Remarks1 , Remarks2 = @Remarks2 , Remarks3 = @Remarks3 " & _
        '                    " , MPILTime = @MPILTime , RunOuts = @RunOuts , RunBacks = @RunBacks where Heat = @Heat  "

        '        If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
        '        oCmd.Transaction = oCmd.Connection.BeginTransaction
        '        oCmd.CommandText = " select @cnt = count(*) from mm_MRHeatPosition where Heat = @Heat "
        '        oCmd.ExecuteScalar()
        '        Done = IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value)
        '        If Done Then
        '            oCmd.CommandText = strUpdate
        '        Else
        '            oCmd.CommandText = strInsert
        '        End If
        '        Done = False
        '        oCmd.Parameters.Add("@Remarks1", SqlDbType.VarChar, 500).Value = Remarks1
        '        oCmd.Parameters.Add("@Remarks2", SqlDbType.VarChar, 500).Value = Remarks2
        '        oCmd.Parameters.Add("@Remarks3", SqlDbType.VarChar, 500).Value = Remarks3
        '        oCmd.Parameters.Add("@MPILTime", SqlDbType.SmallDateTime, 4).Value = CDate(str)
        '        oCmd.Parameters.Add("@RunOuts", SqlDbType.Int, 4).Value = Val(RunOuts)
        '        oCmd.Parameters.Add("@RunBacks", SqlDbType.Int, 4).Value = Val(RunBacks)
        '        If oCmd.ExecuteNonQuery = 1 Then Done = True
        '    Catch exp As Exception
        '        Throw New Exception(exp.Message)
        '    Finally
        '        If Not IsNothing(oCmd) Then
        '            If Done Then
        '                oCmd.Transaction.Commit()
        '            Else
        '                oCmd.Transaction.Rollback()
        '            End If
        '            If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
        '            oCmd.Dispose()
        '            oCmd = Nothing
        '            strInsert = Nothing
        '            strUpdate = Nothing
        '        End If
        '    End Try
        '    Return Done
        'End Function

        Public Function SaveMRHeatPosition(ByVal str As String, ByVal Heat As Long, ByVal Remarks1 As String, ByVal Remarks2 As String, ByVal Remarks3 As String, ByVal RunOuts As Integer, ByVal RunBacks As Integer, ByVal XC50 As String, ByVal Overflow As String) As Boolean
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            Dim strInsert, strUpdate As String
            Dim Done As Boolean
            Try
                oCmd.Parameters.Add("@heat", SqlDbType.BigInt, 8).Value = CLng(Heat)
                oCmd.Parameters.Add("@cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output

                strInsert = " insert into mm_MRHeatPositionNew ( Heat , Remarks1 , Remarks2 , Remarks3 , MPILTime , RunOuts , RunBacks )" &
                 " values ( @Heat , @Remarks1 , @Remarks2 , @Remarks3 , @MPILTime , @RunOuts , @RunBacks,@XC50,@Overflow )"


                strUpdate = " update mm_MRHeatPositionNew set Remarks1 = @Remarks1 , Remarks2 = @Remarks2 , Remarks3 = @Remarks3 " &
                            " , MPILTime = @MPILTime , RunOuts = @RunOuts , RunBacks = @RunBacks ,XC50=@XC50, Overflow= @Overflow  where Heat = @Heat "

                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.Transaction = oCmd.Connection.BeginTransaction
                oCmd.CommandText = " select @cnt = count(*) from mm_MRHeatPositionNew where Heat = @Heat "
                oCmd.ExecuteScalar()
                Done = IIf(IsDBNull(oCmd.Parameters("@cnt").Value), 0, oCmd.Parameters("@cnt").Value)
                If Done Then
                    oCmd.CommandText = strUpdate
                Else
                    oCmd.CommandText = strInsert
                End If
                Done = False
                oCmd.Parameters.Add("@Remarks1", SqlDbType.VarChar, 500).Value = Remarks1
                oCmd.Parameters.Add("@Remarks2", SqlDbType.VarChar, 500).Value = Remarks2
                oCmd.Parameters.Add("@Remarks3", SqlDbType.VarChar, 500).Value = Remarks3
                oCmd.Parameters.Add("@MPILTime", SqlDbType.SmallDateTime, 4).Value = CDate(str)
                oCmd.Parameters.Add("@RunOuts", SqlDbType.Int, 4).Value = Val(RunOuts)
                oCmd.Parameters.Add("@RunBacks", SqlDbType.Int, 4).Value = Val(RunBacks)
                oCmd.Parameters.Add("@XC50", SqlDbType.VarChar, 500).Value = XC50
                oCmd.Parameters.Add("@Overflow", SqlDbType.VarChar, 500).Value = Overflow
                If oCmd.ExecuteNonQuery = 1 Then Done = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If Not IsNothing(oCmd) Then
                    If Done Then
                        oCmd.Transaction.Commit()
                    Else
                        oCmd.Transaction.Rollback()
                    End If
                    If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                    oCmd.Dispose()
                    oCmd = Nothing
                    strInsert = Nothing
                    strUpdate = Nothing
                End If
            End Try
            Return Done
        End Function

        Public Function UpdateLadleWeights(ByVal Heat As Long, ByVal W3 As Double, ByVal wt As Double, ByVal wp As Double) As Boolean
            Dim Done As Boolean
            Try
                Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                Try
                    oCmd.Parameters.Add("@Heat", SqlDbType.BigInt, 8).Value = Heat
                    oCmd.Parameters.Add("@W3", SqlDbType.Float, 8).Value = W3
                    oCmd.Parameters.Add("@wt", SqlDbType.Float, 8).Value = wt
                    oCmd.Parameters.Add("@wp", SqlDbType.Float, 8).Value = wp
                    oCmd.CommandText = "update mm_ladleweights set w3 = @W3 , wt = @wt , wp = @wp where heat_number = @Heat "
                    oCmd.Transaction = oCmd.Connection.BeginTransaction
                    If oCmd.ExecuteNonQuery = 1 Then Done = True
                Catch exp As Exception
                    Throw New Exception(exp.Message)
                Finally
                    If Not IsNothing(oCmd) Then
                        If Done Then
                            oCmd.Transaction.Commit()
                        Else
                            oCmd.Transaction.Rollback()
                        End If
                        If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                        oCmd.Dispose()
                        oCmd = Nothing
                    End If
                End Try
            Catch exp As Exception
                Throw New Exception(exp.Message)
                Done = False
            End Try
            Return Done
        End Function
        Public Function GetNextMonth(ByVal Group As String) As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj
            ' sp will not go beyond one month. retries will land back in the same month
            cmd.CommandText = "mm_sp_si_InitialiseNextMonthGB"
            cmd.Parameters.Add("@ShopCode", SqlDbType.VarChar, 4).Direction = ParameterDirection.Input
            If Group = "WHLMLT" Then
                cmd.Parameters("@ShopCode").Value = "MEME"
            ElseIf Group = "MLDING" Then
                cmd.Parameters("@ShopCode").Value = "MOPO"
            Else
                Throw New Exception("Initialisation failure !")
            End If
            cmd.CommandType = CommandType.StoredProcedure
            Dim blnDone As Boolean
            Try
                cmd.Connection.Open()
                cmd.Transaction = cmd.Connection.BeginTransaction
                cmd.ExecuteNonQuery()
                blnDone = True
            Catch exp As Exception
                Throw New Exception("Initialisation failure. " & exp.Message)
            Finally
                If IsNothing(cmd.Transaction) = False Then
                    If blnDone = False Then
                        cmd.Transaction.Rollback()
                    Else
                        cmd.Transaction.Commit()
                    End If
                End If
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            Return blnDone
        End Function
        Public Function UpdateGroundBalance(ByVal PlTbl As DataTable, ByVal ConDate As Date, ByVal SubShop As String, ByVal UserID As String, ByVal ReceiptDate As Date, ByVal FirstConDate As Date, ByVal woTbl As DataTable) As Boolean
            Dim tbl As DataTable = CType(PlTbl, DataTable)
            Dim row As DataRow
            Dim blnDone As Boolean
            Dim modeObCb, modeReceipt, modeConsumption As String
            Dim strUpdtConsumption, strChkExistenceConsumption, strInsertConsumption As String
            strUpdtConsumption = "update c set c.quantity = @ConsumedQty from  mm_daily_pl_consumption c where " & _
                                 " c.pl_number = @plNumber and  consumed_date = @consumedDate and workorder_number = @wo "
            strChkExistenceConsumption = "select @ConsumptionExists = count(*) from  mm_daily_pl_consumption c where c.pl_number = @plNumber and  consumed_date = @consumedDate and workorder_number = @wo"
            strInsertConsumption = "insert into  mm_daily_pl_consumption (consumed_date, Shift_Code, Shop_Code, Workorder_number, " & _
                                   " pl_number, quantity ) values (@ConsumedDate, @shiftCode, @shopCode, @wo, @plNumber, @ConsumedQty ) "

            Dim strUpdtReceipt, strChkExistenceReceipt, strInsertReceipt, strGetReceiptCode As String
            strUpdtReceipt = "update a set a.quantity_received = @ReceivedQty, a.Employee_code = @EmpCode from mm_shop_pl_receipt a where a.pl_number = @plNumber and shop_code = @shopCode and receipt_date = @ReceiptDate"
            strInsertReceipt = "insert into mm_shop_pl_receipt ( Pl_Number, Shop_Code, Quantity_Received, Receipt_Date, Employee_code  )   values ( @PlNumber, @shopCode, @ReceivedQty, @ReceiptDate, @EmpCode )"
            strChkExistenceReceipt = "Select @ReceiptExists = count(*) from mm_shop_pl_receipt a where a.pl_number = @plNumber and shop_code = @shopCode and receipt_date = @ReceiptDate"

            strGetReceiptCode = "select top 1 isnull(receipt_code,0) from mm_shop_pl_receipt order by receipt_code desc"


            Dim strUpdtOBCB, strCheckExistenceOBCB, strInsertOBCB As String
            strUpdtOBCB = "update a set a.Opening_balance = @OpeningBalance, a.Closing_Balance = @ClosingBalance " & _
                          " from mm_shop_accountal a where a.pl_number = @PlNumber and a.shop_code = @shopCode and " & _
                          " a.record_date = @OBCBDate"
            strCheckExistenceOBCB = "select @ObCbExists = count(*) from mm_shop_accountal a where a.pl_number = @PlNumber and a.shop_code = @shopCode and a.record_date = @OBCBDate"
            strInsertOBCB = "insert into mm_shop_accountal (record_date, shop_code, pl_number, opening_balance, Closing_Balance ) values ( @ObCbDate, @shopCode, @plNumber, @OpeningBalance, @ClosingBalance )"

            Dim params(15) As SqlClient.SqlParameter
            params(0) = New SqlClient.SqlParameter("@ConsumedQty", SqlDbType.Decimal, 4)
            params(1) = New SqlClient.SqlParameter("@plNumber", SqlDbType.VarChar, 8)
            params(2) = New SqlClient.SqlParameter("@consumedDate", SqlDbType.SmallDateTime, 4)
            params(3) = New SqlClient.SqlParameter("@wo", SqlDbType.VarChar, 4)
            params(4) = New SqlClient.SqlParameter("@ConsumptionExists", SqlDbType.Int, 4)
            params(5) = New SqlClient.SqlParameter("@shiftCode", SqlDbType.VarChar, 1)
            params(6) = New SqlClient.SqlParameter("@shopCode", SqlDbType.VarChar, 4)
            params(7) = New SqlClient.SqlParameter("@ReceivedQty", SqlDbType.Decimal, 4)
            params(8) = New SqlClient.SqlParameter("@EmpCode", SqlDbType.VarChar, 6)
            params(9) = New SqlClient.SqlParameter("@ReceiptDate", SqlDbType.SmallDateTime, 4)
            params(10) = New SqlClient.SqlParameter("@ReceiptExists", SqlDbType.Int, 4)
            params(11) = New SqlClient.SqlParameter("@OpeningBalance", SqlDbType.Decimal, 4)
            params(12) = New SqlClient.SqlParameter("@ClosingBalance", SqlDbType.Decimal, 4)
            params(13) = New SqlClient.SqlParameter("@OBCBDate", SqlDbType.SmallDateTime, 4)
            params(14) = New SqlClient.SqlParameter("@ObCbExists", SqlDbType.Int, 4)

            Dim i As Integer
            For i = 0 To 14
                If i = 4 Or i = 10 Or i = 14 Then
                    params(i).Direction = ParameterDirection.Output
                Else
                    params(i).Direction = ParameterDirection.Input
                End If
            Next
            Dim rw As DataRow

            For Each row In tbl.Rows
                ' assign values to params
                Try
                    params(1).Value = row("plNo")
                    params(2).Value = CDate(ConDate) ' consumed date
                    params(5).Value = "A"
                    params(6).Value = SubShop
                    params(7).Value = row("Receipt")
                    params(8).Value = UserID
                    params(9).Value = CDate(ReceiptDate) ' 
                    params(11).Value = row("OB")
                    params(12).Value = row("CB")
                    params(13).Value = CDate(FirstConDate)

                    ' values to be updated before each save
                    params(0).Value = 0 ' consumed qty
                    params(3).Value = "" ' wo
                    blnDone = True
                Catch exp As Exception
                    Throw New Exception(exp.Message)
                End Try
                If blnDone = False Then
                    Exit Function
                End If
                blnDone = False
                Dim blnObCbSaved, blnReceiptSaved, blnConsumptionSaved As Boolean
                Dim cmd As New SqlClient.SqlCommand()
                cmd.Connection = rwfGen.Connection.ConObj
                i = 0
                For i = 0 To 14
                    cmd.Parameters.Add(params(i))
                Next
                ' execute save commands
                Try
                    cmd.Connection.Open()
                    cmd.CommandText = strCheckExistenceOBCB
                    cmd.ExecuteScalar()
                    If cmd.Parameters("@ObCbExists").Value > 0 Then
                        modeObCb = "Update"
                    Else
                        modeObCb = "Insert"
                    End If
                    cmd.CommandText = strChkExistenceReceipt
                    cmd.ExecuteScalar()
                    If cmd.Parameters("@ReceiptExists").Value > 0 Then
                        modeReceipt = "Update"
                    Else
                        modeReceipt = "Insert"
                    End If
                    If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                    cmd.Connection.Open()
                    cmd.Transaction = cmd.Connection.BeginTransaction
                    If modeObCb = "Insert" Then
                        cmd.CommandText = strInsertOBCB
                        cmd.ExecuteNonQuery()
                        blnObCbSaved = True
                    ElseIf modeObCb = "Update" Then
                        cmd.CommandText = strUpdtOBCB
                        cmd.ExecuteNonQuery()
                        blnObCbSaved = True
                    End If
                    If modeReceipt = "Insert" Then
                        cmd.CommandText = strGetReceiptCode
                        cmd.Parameters.Add("@ReceiptCode", SqlDbType.Int, 4)
                        cmd.Parameters("@ReceiptCode").Direction = ParameterDirection.Output
                        cmd.Parameters("@ReceiptCode").Value = cmd.ExecuteScalar
                        cmd.Parameters("@ReceiptCode").Value += 1
                        cmd.Parameters("@ReceiptCode").Direction = ParameterDirection.Input
                        cmd.CommandText = strInsertReceipt
                        cmd.ExecuteNonQuery()
                        blnReceiptSaved = True
                    ElseIf modeReceipt = "Update" Then
                        cmd.CommandText = strUpdtReceipt
                        cmd.ExecuteNonQuery()
                        blnReceiptSaved = True
                    End If
                    For Each rw In CType(woTbl, DataTable).Rows
                        params(3).Value = rw("number") ' wo
                        params(0).Value = row(params(3).Value) ' consumed qty
                        cmd.CommandText = strChkExistenceConsumption
                        cmd.ExecuteScalar()
                        If cmd.Parameters("@ConsumptionExists").Value > 0 Then
                            modeConsumption = "Update"
                        Else
                            modeConsumption = "Insert"
                        End If
                        If modeConsumption = "Insert" Then
                            cmd.CommandText = strInsertConsumption
                            cmd.ExecuteNonQuery()
                            blnConsumptionSaved = True
                        ElseIf modeConsumption = "Update" Then
                            cmd.CommandText = strUpdtConsumption
                            cmd.ExecuteNonQuery()
                            blnConsumptionSaved = True
                        End If
                    Next
                    blnDone = blnConsumptionSaved And blnReceiptSaved And blnObCbSaved
                Catch exp As Exception
                    Throw New Exception(exp.Message)
                    blnDone = False
                Finally
                    If Not blnDone Then
                        If IsNothing(cmd) = False Then cmd.Transaction.Rollback()
                    Else
                        If IsNothing(cmd) = False Then cmd.Transaction.Commit()
                    End If
                    If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                    If IsNothing(cmd) Then cmd.Dispose()
                    cmd = Nothing
                End Try
                If blnDone = False Then
                    Exit For
                End If
                i = 0
                For i = 0 To 14
                    cmd.Parameters.Remove(params(i))
                Next
                blnObCbSaved = Nothing
                blnReceiptSaved = Nothing
                blnConsumptionSaved = Nothing
            Next
            i = Nothing
            rw = Nothing
            params(15) = Nothing
            strUpdtOBCB = Nothing
            strCheckExistenceOBCB = Nothing
            strInsertOBCB = Nothing
            strUpdtReceipt = Nothing
            strChkExistenceReceipt = Nothing
            strInsertReceipt = Nothing
            strGetReceiptCode = Nothing
            tbl = Nothing
            row = Nothing
            modeObCb = Nothing
            modeReceipt = Nothing
            modeConsumption = Nothing
            strUpdtConsumption = Nothing
            strChkExistenceConsumption = Nothing
            strInsertConsumption = Nothing
            Return blnDone
        End Function
        'Public Function OutTurn(ByVal OutTurnDate As Date, ByVal Shift As String, ByVal ShiftInC As String, ByVal SW1Qty As Integer, ByVal SW1InC As String, ByVal SW1Remarks As String, ByVal SW2Qty As Integer, ByVal SW2InC As String, ByVal SW2Remarks As String, ByVal SW3Qty As Integer, ByVal SW3InC As String, ByVal SW3Remarks As String, ByVal SW4Qty As Integer, ByVal SW4InC As String, ByVal SW4Remarks As String, ByVal SW5Qty As Integer, ByVal SW5InC As String, ByVal SW5Remarks As String, ByVal SW6Qty As Integer, ByVal SW6InC As String, ByVal SW6Remarks As String, ByVal SW7Qty As Integer, ByVal SW7InC As String, ByVal SW7Remarks As String, ByVal SW8Qty As Integer, ByVal SW8InC As String, ByVal SW8Remarks As String, ByVal SGM1Qty As Integer, ByVal SGM1InC As String, ByVal SGM1Remarks As String, ByVal SGM2Qty As Integer, ByVal SGM2InC As String, ByVal SGM2Remarks As String, ByVal SGM3Qty As Integer, ByVal SGM3InC As String, ByVal SGM3Remarks As String, ByVal SGM4Qty As Integer, ByVal SGM4InC As String, ByVal SGM4REmarks As String, ByVal HCM1Qty As Integer, ByVal HCM1InC As String, ByVal HCM1Remarks As String, ByVal HCM2Qty As Integer, ByVal HCM2InC As String, ByVal HCM2Remarks As String, ByVal HCM3Qty As Integer, ByVal HCM3InC As String, ByVal HCM3Remarks As String, ByVal HCM4Qty As String, ByVal HCM4InC As String, ByVal HCM4Remarks As String, ByVal HCM5Qty As Integer, ByVal HCM5InC As String, ByVal HCM5Remarks As String, ByVal NFCQty As Integer, ByVal NFCInC As String, ByVal NFCRemarks As String, ByVal NFDQty As Integer, ByVal NFDInC As String, ByVal NFDRemarks As String, ByVal DFDQty As Integer, ByVal DFDInC As String, ByVal DFDRemarks As String, ByVal CBQty As Integer, ByVal CBInC As String, ByVal CBRemarks As String, ByVal CSQty As Integer, ByVal CSInC As String, ByVal CSRemarks As String, ByVal DSQty As Integer, ByVal DSInC As String, ByVal DSRemarks As String, ByVal COLQty As Integer, ByVal COLInC As String, ByVal COLRemarks As String, ByVal DOLQty As Integer, ByVal DOLInC As String, ByVal DOLRemarks As String, ByVal WhlsCast As Integer, ByVal MROffLoad As Integer, ByVal SWLess400 As Integer, ByVal HCLess250 As Integer, ByVal CSGr230 As Integer, ByVal CSLess170 As Integer, ByVal DSGr230 As Integer, ByVal DSLess170 As Integer, ByVal SWRecSts As String, ByVal HCRecSts As String, ByVal CSRecSts As String, ByVal DSRecSts As String, ByVal RK1BrushSts As String, ByVal RK2BrushSts As String, ByVal C5IE As String, ByVal C5IW As String, ByVal C5KE As String, ByVal C5KW As String, ByVal SWCQty As Integer, ByVal SWCInC As String, ByVal SWCRemarks As String, ByVal SWPGQty As Integer, ByVal SWPGInC As String, ByVal SWPGRemarks As String, ByVal NBDQty As Integer, ByVal NBDInC As String, ByVal NBDRemarks As String, ByVal DDUQty As Integer, ByVal DDUInC As String, ByVal DDURemarks As String, ByVal CopesQty As Integer, ByVal CopesInC As String, ByVal CopesRemarks As String, ByVal DragsQty As Integer, ByVal DragsInC As String, ByVal DragsRemarks As String, ByVal SandQty As Integer, ByVal SandInC As String, ByVal SandRemarks As String, ByVal PTQty As Integer, ByVal PTInC As String, ByVal PTRemarks As String, ByVal MPO1 As String, ByVal MPO2 As String, ByVal MPO3 As String, ByVal BucketsQty As Integer, ByVal BucketsInC As String, ByVal BucketsRemarks As String) As Boolean
        '    Dim blnInsert As Boolean
        '    Dim ds As New DataSet()
        '    Try
        '        ds = RWF.MLDING.CheckOutTurn(CDate(OutTurnDate), Shift)
        '        If ds.Tables(0).Rows.Count = 0 Then
        '            blnInsert = True
        '        End If
        '    Catch exp As Exception
        '        Throw New Exception(exp.Message)
        '    Finally
        '        ds.Dispose()
        '        ds = Nothing
        '    End Try
        '    Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
        '    Dim Done As Boolean
        '    Dim strInsert, strUpdate As String
        '    Try
        '        oCmd.Parameters.Add("@OutTurnDate", SqlDbType.SmallDateTime, 4).Value = CDate(OutTurnDate)
        '        oCmd.Parameters.Add("@Shift", SqlDbType.VarChar, 1).Value = Shift

        '        strInsert = " insert into mm_MROutTurn ( OutTurnDate,Shift,WhlsCast , MROffLoad , SW1Qty,SW1InC,SW1Remarks,SW2Qty,SW2InC,SW2Remarks,SW3Qty," & _
        '                    " SW3InC,SW3Remarks,SW4Qty,SW4InC,SW4Remarks,SW5Qty,SW5InC,SW5Remarks,SW6Qty," & _
        '                    " SW6InC,SW6Remarks,SW7Qty,SW7InC,SW7Remarks,SW8Qty,SW8InC,SW8Remarks,SGM1Qty," & _
        '                    " SGM1InC,SGM1Remarks,SGM2Qty,SGM2InC,SGM2Remarks,SGM3Qty,SGM3InC,SGM3Remarks," & _
        '                    " SGM4Qty,SGM4InC,SGM4REmarks,HCM1Qty,HCM1InC,HCM1Remarks,HCM2Qty,HCM2InC," & _
        '                    " HCM2Remarks,HCM3Qty,HCM3InC,HCM3Remarks,HCM4Qty,HCM4InC,HCM4Remarks,HCM5Qty," & _
        '                    " HCM5InC,HCM5Remarks,NFCQty,NFCInC,NFCRemarks,NFDQty,NFDInC,NFDRemarks," & _
        '                    " DFDQty, DFDInC, DFDRemarks, CBQty, CBInC, CBRemarks, " & _
        '                    " CSQty,CSInC,CSRemarks,DSQty,DSInC,DSRemarks,COLQty,COLInC, " & _
        '                    " COLRemarks, DOLQty, DOLInC, DOLRemarks, ShiftInC , " & _
        '                    " SWLess400 , HCLess250 , CSGr230 , CSLess170 , DSGr230 , DSLess170 , SWRecSts , " & _
        '                    " HCRecSts , CSRecSts , DSRecSts , RK1BrushSts , RK2BrushSts , C5IE , C5IW , C5KE , C5KW ,  " & _
        '                    " SWCQty , SWCInC  , SWCRemarks  , SWPGQty  , SWPGInC  , SWPGRemarks , " & _
        '                    " NBDQty , NBDInC , NBDRemarks , DDUQty , DDUInC , DDURemarks , " & _
        '                    " CopesQty , CopesInC , CopesRemarks  , DragsQty  , DragsInC  , DragsRemarks , " & _
        '                    " SandQty   , SandInC , SandRemarks , PTQty  , PTInC   , PTRemarks   , MPO1  , MPO2  , MPO3 , " & _
        '                    " BucketsQty , BucketsInC , BucketsRemarks ) " & _
        '                    " values ( @OutTurnDate,@Shift,@WhlsCast , @MROffLoad , @SW1Qty,@SW1InC,@SW1Remarks,@SW2Qty,@SW2InC,@SW2Remarks,@SW3Qty," & _
        '                    " @SW3InC,@SW3Remarks,@SW4Qty,@SW4InC,@SW4Remarks,@SW5Qty,@SW5InC,@SW5Remarks,@SW6Qty," & _
        '                    " @SW6InC,@SW6Remarks,@SW7Qty,@SW7InC,@SW7Remarks,@SW8Qty,@SW8InC,@SW8Remarks,@SGM1Qty," & _
        '                    " @SGM1InC,@SGM1Remarks,@SGM2Qty,@SGM2InC,@SGM2Remarks,@SGM3Qty,@SGM3InC,@SGM3Remarks," & _
        '                    " @SGM4Qty,@SGM4InC,@SGM4REmarks,@HCM1Qty,@HCM1InC,@HCM1Remarks,@HCM2Qty,@HCM2InC," & _
        '                    " @HCM2Remarks,@HCM3Qty,@HCM3InC,@HCM3Remarks,@HCM4Qty,@HCM4InC,@HCM4Remarks,@HCM5Qty," & _
        '                    " @HCM5InC,@HCM5Remarks,@NFCQty,@NFCInC,@NFCRemarks,@NFDQty,@NFDInC,@NFDRemarks," & _
        '                    " @DFDQty, @DFDInC, @DFDRemarks, @CBQty, @CBInC, @CBRemarks, " & _
        '                    " @CSQty,@CSInC,@CSRemarks,@DSQty,@DSInC,@DSRemarks,@COLQty,@COLInC, " & _
        '                    " @COLRemarks, @DOLQty, @DOLInC, @DOLRemarks, @ShiftInC , " & _
        '                    " @SWLess400 , @HCLess250 , @CSGr230 , @CSLess170 , @DSGr230 , @DSLess170 , @SWRecSts , " & _
        '                    " @HCRecSts , @CSRecSts , @DSRecSts , @RK1BrushSts , @RK2BrushSts , @C5IE , @C5IW , @C5KE , @C5KW , " & _
        '                    " @SWCQty , @SWCInC , @SWCRemarks , @SWPGQty , @SWPGInC , @SWPGRemarks ," & _
        '                    " @NBDQty , @NBDInC , @NBDRemarks , @DDUQty , @DDUInC , @DDURemarks , " & _
        '                    " @CopesQty , @CopesInC , @CopesRemarks  , @DragsQty  , @DragsInC  , @DragsRemarks , " & _
        '                    " @SandQty   , @SandInC , @SandRemarks , @PTQty  , @PTInC   , @PTRemarks   , @MPO1  , @MPO2  , @MPO3 , " & _
        '                    " @BucketsQty , @BucketsInC , @BucketsRemarks ) "

        '        strUpdate = " update mm_MROutTurn set WhlsCast = @WhlsCast ,  MROffLoad = @MROffLoad , SW1Qty = @SW1Qty, SW1InC = @SW1InC ,SW1Remarks = @SW1Remarks , SW2Qty = @SW2Qty ," & _
        '                    " SW2InC = @SW2InC , SW2Remarks = @SW2Remarks , SW3Qty = @SW3Qty , " & _
        '                    " SW3InC   =  @SW3InC ,  SW3Remarks   =  @SW3Remarks ,  SW4Qty   =  @SW4Qty ,  SW4InC   =  @SW4InC ," & _
        '                    " SW4Remarks   =  @SW4Remarks ,  SW5Qty   =  @SW5Qty ,  SW5InC   =  @SW5InC ,  SW5Remarks   =  @SW5Remarks , " & _
        '                    " SW6Qty   =  @SW6Qty ,  SW6InC   = @SW6InC  ,  SW6Remarks   =  @SW6Remarks " & _
        '                    ",  SW7Qty   = @SW7Qty   " & _
        '                    " , SW7InC   =  @SW7InC ,  SW7Remarks   =  @SW7Remarks " & _
        '                    " ,  SW8Qty   =  @SW8Qty ,  SW8InC   = @SW8InC ,  " & _
        '                    " SW8Remarks   =  @SW8Remarks ,  SGM1Qty   = @SGM1Qty  ,  SGM1InC   = @SGM1InC ,  SGM1Remarks   = @SGM1Remarks , " & _
        '                    " SGM2Qty   =  @SGM2Qty ,  SGM2InC   = @SGM2InC ,  SGM2Remarks   = @SGM2Remarks ,  SGM3Qty   = @SGM3Qty ,  " & _
        '                    " SGM3InC   =  @SGM3InC ,  SGM3Remarks   =  @SGM3Remarks , SGM4Qty   = @SGM4Qty  ,  SGM4InC   = @SGM4InC ,  " & _
        '                    " SGM4REmarks   =  @SGM4REmarks " & _
        '                    " ,  HCM1Qty   = @HCM1Qty  ,  HCM1InC   =  @HCM1InC ,  HCM1Remarks   =  @HCM1Remarks, " & _
        '                    " HCM2Qty   =  @HCM2Qty ,  HCM2InC   = @HCM2InC ,  HCM2Remarks   =  @HCM2Remarks ,  HCM3Qty   = @HCM3Qty ,  " & _
        '                    " HCM3InC   =  @HCM3InC ,  HCM3Remarks   = @HCM3Remarks  ,  HCM4Qty   = @HCM4Qty  ,  HCM4InC   =  @HCM4InC,  " & _
        '                    " HCM4Remarks   =  @HCM4Remarks ,  HCM5Qty   =  @HCM5Qty ,  HCM5InC   = @HCM5InC ,  HCM5Remarks   =  @HCM5Remarks , " & _
        '                    " NFCQty   =  @NFCQty ,  NFCInC   = @NFCInC ,  NFCRemarks   = @NFCRemarks ,  NFDQty   = @NFDQty ,  " & _
        '                    " NFDInC   =  @NFDInC ,  NFDRemarks   = @NFDRemarks ,  DFDQty   =  @DFDQty,  DFDInC   = @DFDInC ,  " & _
        '                    " DFDRemarks   =  @DFDRemarks ,  CBQty   =  @CBQty ,  CBInC   = @CBInC ,  CBRemarks   = @CBRemarks , " & _
        '                    " CSQty   = @CSQty ,  CSInC   = @CSInC ,  CSRemarks   = @CSRemarks ,  DSQty   = @DSQty ,  " & _
        '                    " DSInC   = @DSInC ,  DSRemarks   =  @DSRemarks  " & _
        '                    " , COLQty = @COLQty , COLInC = @COLInC , COLRemarks = @COLRemarks " & _
        '                    " , DOLQty   = @DOLQty ,  DOLInC   = @DOLInC ,  DOLRemarks   =  @DOLRemarks ,  ShiftInC = @ShiftInC " & _
        '                    " , SWLess400 = @SWLess400 , HCLess250 = @HCLess250 , CSGr230 = @CSGr230 ,  " & _
        '                    " CSLess170 = @CSLess170 , DSGr230 = @DSGr230 , DSLess170 = @DSLess170 ,  " & _
        '                    " SWRecSts = @SWRecSts , HCRecSts = @HCRecSts , CSRecSts = @CSRecSts ,  " & _
        '                    " DSRecSts = @DSRecSts , RK1BrushSts = @RK1BrushSts , RK2BrushSts = @RK2BrushSts ,  " & _
        '                    " C5IE = @C5IE , C5IW = @C5IW , C5KE = @C5KE , C5KW = @C5KW , " & _
        '                    " SWCQty = @SWCQty , SWCInC  = @SWCInC , SWCRemarks = @SWCRemarks  , SWPGQty = @SWPGQty  , SWPGInC = @SWPGInC , SWPGRemarks  = @SWPGRemarks , " & _
        '                    " NBDQty = @NBDQty , NBDInC = @NBDInC , NBDRemarks = @NBDRemarks , DDUQty = @DDUQty , DDUInC  = @DDUInC , DDURemarks = @DDURemarks , " & _
        '                    " CopesQty = @CopesQty , CopesInC = @CopesInC , CopesRemarks = @CopesRemarks , " & _
        '                    " DragsQty = @DragsQty , DragsInC = @DragsInC , DragsRemarks = @DragsRemarks , " & _
        '                    " SandQty = @SandQty ,  SandInC = @SandInC , SandRemarks = @SandRemarks , " & _
        '                    " PTQty = @PTQty , PTInC = @PTInC , PTRemarks = @PTRemarks , " & _
        '                    " MPO1 = @MPO1 , MPO2 = @MPO2 , MPO3  = @MPO3 , BucketsQty = @BucketsQty , BucketsInC = @BucketsInC , BucketsRemarks = @BucketsRemarks " & _
        '                    " where OutTurnDate = @OutTurnDate and Shift = @Shift "


        '        If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
        '        oCmd.Transaction = oCmd.Connection.BeginTransaction
        '        If blnInsert Then
        '            oCmd.CommandText = strInsert
        '        Else
        '            oCmd.CommandText = strUpdate
        '        End If
        '        oCmd.Parameters.Add("@ShiftInC", SqlDbType.VarChar, 10).Value = ShiftInC
        '        oCmd.Parameters.Add("@SW1Qty", SqlDbType.Int, 4).Value = Val(SW1Qty)
        '        oCmd.Parameters.Add("@SW1InC", SqlDbType.VarChar, 10).Value = SW1InC
        '        oCmd.Parameters.Add("@SW1Remarks", SqlDbType.VarChar, 100).Value = SW1Remarks
        '        oCmd.Parameters.Add("@SW2Qty", SqlDbType.Int, 4).Value = Val(SW2Qty)
        '        oCmd.Parameters.Add("@SW2InC", SqlDbType.VarChar, 10).Value = SW2InC
        '        oCmd.Parameters.Add("@SW2Remarks", SqlDbType.VarChar, 100).Value = SW2Remarks
        '        oCmd.Parameters.Add("@SW3Qty", SqlDbType.Int, 4).Value = Val(SW3Qty)
        '        oCmd.Parameters.Add("@SW3InC", SqlDbType.VarChar, 10).Value = SW3InC
        '        oCmd.Parameters.Add("@SW3Remarks", SqlDbType.VarChar, 100).Value = SW3Remarks
        '        oCmd.Parameters.Add("@SW4Qty", SqlDbType.Int, 4).Value = Val(SW4Qty)
        '        oCmd.Parameters.Add("@SW4InC", SqlDbType.VarChar, 10).Value = SW4InC
        '        oCmd.Parameters.Add("@SW4Remarks", SqlDbType.VarChar, 100).Value = SW4Remarks
        '        oCmd.Parameters.Add("@SW5Qty", SqlDbType.Int, 4).Value = Val(SW5Qty)
        '        oCmd.Parameters.Add("@SW5InC", SqlDbType.VarChar, 10).Value = SW5InC
        '        oCmd.Parameters.Add("@SW5Remarks", SqlDbType.VarChar, 100).Value = SW5Remarks
        '        oCmd.Parameters.Add("@SW6Qty", SqlDbType.Int, 4).Value = Val(SW6Qty)
        '        oCmd.Parameters.Add("@SW6InC", SqlDbType.VarChar, 10).Value = SW6InC
        '        oCmd.Parameters.Add("@SW6Remarks", SqlDbType.VarChar, 100).Value = SW6Remarks
        '        oCmd.Parameters.Add("@SW7Qty", SqlDbType.Int, 4).Value = Val(SW7Qty)
        '        oCmd.Parameters.Add("@SW7InC", SqlDbType.VarChar, 10).Value = SW7InC
        '        oCmd.Parameters.Add("@SW7Remarks", SqlDbType.VarChar, 100).Value = SW7Remarks
        '        oCmd.Parameters.Add("@SW8Qty", SqlDbType.Int, 4).Value = Val(SW8Qty)
        '        oCmd.Parameters.Add("@SW8InC", SqlDbType.VarChar, 10).Value = SW8InC
        '        oCmd.Parameters.Add("@SW8Remarks", SqlDbType.VarChar, 100).Value = SW8Remarks
        '        oCmd.Parameters.Add("@SGM1Qty", SqlDbType.Int, 4).Value = Val(SGM1Qty)
        '        oCmd.Parameters.Add("@SGM1InC", SqlDbType.VarChar, 10).Value = SGM1InC
        '        oCmd.Parameters.Add("@SGM1Remarks", SqlDbType.VarChar, 100).Value = SGM1Remarks
        '        oCmd.Parameters.Add("@SGM2Qty", SqlDbType.Int, 4).Value = Val(SGM2Qty)
        '        oCmd.Parameters.Add("@SGM2InC", SqlDbType.VarChar, 10).Value = SGM2InC
        '        oCmd.Parameters.Add("@SGM2Remarks", SqlDbType.VarChar, 100).Value = SGM2Remarks
        '        oCmd.Parameters.Add("@SGM3Qty", SqlDbType.Int, 4).Value = Val(SGM3Qty)
        '        oCmd.Parameters.Add("@SGM3InC", SqlDbType.VarChar, 10).Value = SGM3InC
        '        oCmd.Parameters.Add("@SGM3Remarks", SqlDbType.VarChar, 100).Value = SGM3Remarks
        '        oCmd.Parameters.Add("@SGM4Qty", SqlDbType.Int, 4).Value = Val(SGM4Qty)
        '        oCmd.Parameters.Add("@SGM4InC", SqlDbType.VarChar, 10).Value = SGM4InC
        '        oCmd.Parameters.Add("@SGM4REmarks", SqlDbType.VarChar, 100).Value = SGM4REmarks
        '        oCmd.Parameters.Add("@HCM1Qty", SqlDbType.Int, 4).Value = Val(HCM1Qty)
        '        oCmd.Parameters.Add("@HCM1InC", SqlDbType.VarChar, 10).Value = HCM1InC
        '        oCmd.Parameters.Add("@HCM1Remarks", SqlDbType.VarChar, 100).Value = HCM1Remarks
        '        oCmd.Parameters.Add("@HCM2Qty", SqlDbType.Int, 4).Value = Val(HCM2Qty)
        '        oCmd.Parameters.Add("@HCM2InC", SqlDbType.VarChar, 10).Value = HCM2InC
        '        oCmd.Parameters.Add("@HCM2Remarks", SqlDbType.VarChar, 100).Value = HCM2Remarks
        '        oCmd.Parameters.Add("@HCM3Qty", SqlDbType.Int, 4).Value = Val(HCM3Qty)
        '        oCmd.Parameters.Add("@HCM3InC", SqlDbType.VarChar, 10).Value = HCM3InC
        '        oCmd.Parameters.Add("@HCM3Remarks", SqlDbType.VarChar, 100).Value = HCM3Remarks
        '        oCmd.Parameters.Add("@HCM4Qty", SqlDbType.Int, 4).Value = Val(HCM4Qty)
        '        oCmd.Parameters.Add("@HCM4InC", SqlDbType.VarChar, 10).Value = HCM4InC
        '        oCmd.Parameters.Add("@HCM4Remarks", SqlDbType.VarChar, 100).Value = HCM4Remarks
        '        oCmd.Parameters.Add("@HCM5Qty", SqlDbType.Int, 4).Value = Val(HCM5Qty)
        '        oCmd.Parameters.Add("@HCM5InC", SqlDbType.VarChar, 10).Value = HCM5InC
        '        oCmd.Parameters.Add("@HCM5Remarks", SqlDbType.VarChar, 100).Value = HCM5Remarks
        '        oCmd.Parameters.Add("@NFCQty", SqlDbType.Int, 4).Value = Val(NFCQty)
        '        oCmd.Parameters.Add("@NFCInC", SqlDbType.VarChar, 10).Value = NFCInC
        '        oCmd.Parameters.Add("@NFCRemarks", SqlDbType.VarChar, 100).Value = NFCRemarks
        '        oCmd.Parameters.Add("@NFDQty", SqlDbType.Int, 4).Value = Val(NFDQty)
        '        oCmd.Parameters.Add("@NFDInC", SqlDbType.VarChar, 10).Value = NFDInC
        '        oCmd.Parameters.Add("@NFDRemarks", SqlDbType.VarChar, 100).Value = NFDRemarks
        '        oCmd.Parameters.Add("@DFDQty", SqlDbType.Int, 4).Value = Val(DFDQty)
        '        oCmd.Parameters.Add("@DFDInC", SqlDbType.VarChar, 10).Value = DFDInC
        '        oCmd.Parameters.Add("@DFDRemarks", SqlDbType.VarChar, 100).Value = DFDRemarks
        '        oCmd.Parameters.Add("@CBQty", SqlDbType.Int, 4).Value = Val(CBQty)
        '        oCmd.Parameters.Add("@CBInC", SqlDbType.VarChar, 10).Value = CBInC
        '        oCmd.Parameters.Add("@CBRemarks", SqlDbType.VarChar, 100).Value = CBRemarks
        '        oCmd.Parameters.Add("@CSQty", SqlDbType.Int, 4).Value = Val(CSQty)
        '        oCmd.Parameters.Add("@CSInC", SqlDbType.VarChar, 10).Value = CSInC
        '        oCmd.Parameters.Add("@CSRemarks", SqlDbType.VarChar, 100).Value = CSRemarks
        '        oCmd.Parameters.Add("@DSQty", SqlDbType.Int, 4).Value = Val(DSQty)
        '        oCmd.Parameters.Add("@DSInC", SqlDbType.VarChar, 10).Value = DSInC
        '        oCmd.Parameters.Add("@DSRemarks", SqlDbType.VarChar, 100).Value = DSRemarks
        '        oCmd.Parameters.Add("@COLQty", SqlDbType.Int, 4).Value = Val(COLQty)
        '        oCmd.Parameters.Add("@COLInC", SqlDbType.VarChar, 10).Value = COLInC
        '        oCmd.Parameters.Add("@COLRemarks", SqlDbType.VarChar, 100).Value = COLRemarks
        '        oCmd.Parameters.Add("@DOLQty", SqlDbType.Int, 4).Value = Val(DOLQty)
        '        oCmd.Parameters.Add("@DOLInC", SqlDbType.VarChar, 10).Value = DOLInC
        '        oCmd.Parameters.Add("@DOLRemarks", SqlDbType.VarChar, 100).Value = DOLRemarks
        '        oCmd.Parameters.Add("@WhlsCast", SqlDbType.Int, 4).Value = Val(WhlsCast)
        '        oCmd.Parameters.Add("@MROffLoad", SqlDbType.Int, 4).Value = Val(MROffLoad)
        '        oCmd.Parameters.Add("@SWLess400", SqlDbType.Int, 4).Value = Val(SWLess400)
        '        oCmd.Parameters.Add("@HCLess250", SqlDbType.Int, 4).Value = Val(HCLess250)
        '        oCmd.Parameters.Add("@CSGr230", SqlDbType.Int, 4).Value = Val(CSGr230)
        '        oCmd.Parameters.Add("@CSLess170", SqlDbType.Int, 4).Value = Val(CSLess170)
        '        oCmd.Parameters.Add("@DSGr230", SqlDbType.Int, 4).Value = Val(DSGr230)
        '        oCmd.Parameters.Add("@DSLess170", SqlDbType.Int, 4).Value = Val(DSLess170)
        '        oCmd.Parameters.Add("@SWRecSts", SqlDbType.VarChar, 100).Value = SWRecSts
        '        oCmd.Parameters.Add("@HCRecSts", SqlDbType.VarChar, 100).Value = HCRecSts
        '        oCmd.Parameters.Add("@CSRecSts", SqlDbType.VarChar, 100).Value = CSRecSts
        '        oCmd.Parameters.Add("@DSRecSts", SqlDbType.VarChar, 100).Value = DSRecSts
        '        oCmd.Parameters.Add("@RK1BrushSts", SqlDbType.VarChar, 100).Value = RK1BrushSts
        '        oCmd.Parameters.Add("@RK2BrushSts", SqlDbType.VarChar, 100).Value = RK2BrushSts
        '        oCmd.Parameters.Add("@C5IE", SqlDbType.VarChar, 100).Value = C5IE
        '        oCmd.Parameters.Add("@C5IW", SqlDbType.VarChar, 100).Value = C5IW
        '        oCmd.Parameters.Add("@C5KE", SqlDbType.VarChar, 100).Value = C5KE
        '        oCmd.Parameters.Add("@C5KW", SqlDbType.VarChar, 100).Value = C5KW
        '        oCmd.Parameters.Add("@SWCQty", SqlDbType.Int, 4).Value = Val(SWCQty)
        '        oCmd.Parameters.Add("@SWCInC", SqlDbType.VarChar, 10).Value = SWCInC
        '        oCmd.Parameters.Add("@SWCRemarks", SqlDbType.VarChar, 100).Value = SWCRemarks
        '        oCmd.Parameters.Add("@SWPGQty", SqlDbType.Int, 4).Value = Val(SWPGQty)
        '        oCmd.Parameters.Add("@SWPGInC", SqlDbType.VarChar, 10).Value = SWPGInC
        '        oCmd.Parameters.Add("@SWPGRemarks", SqlDbType.VarChar, 100).Value = SWPGRemarks

        '        oCmd.Parameters.Add("@NBDQty", SqlDbType.Int, 4).Value = Val(NBDQty)
        '        oCmd.Parameters.Add("@NBDInC", SqlDbType.VarChar, 10).Value = NBDInC.Trim
        '        oCmd.Parameters.Add("@NBDRemarks", SqlDbType.VarChar, 100).Value = NBDRemarks.Trim

        '        oCmd.Parameters.Add("@CopesQty", SqlDbType.Int, 4).Value = Val(CopesQty)
        '        oCmd.Parameters.Add("@CopesInC", SqlDbType.VarChar, 10).Value = CopesInC.Trim
        '        oCmd.Parameters.Add("@CopesRemarks", SqlDbType.VarChar, 100).Value = CopesRemarks.Trim

        '        oCmd.Parameters.Add("@DragsQty", SqlDbType.Int, 4).Value = Val(DragsQty)
        '        oCmd.Parameters.Add("@DragsInC", SqlDbType.VarChar, 10).Value = DragsInC.Trim
        '        oCmd.Parameters.Add("@DragsRemarks", SqlDbType.VarChar, 100).Value = DragsRemarks.Trim

        '        oCmd.Parameters.Add("@DDUQty", SqlDbType.Int, 4).Value = Val(DDUQty)
        '        oCmd.Parameters.Add("@DDUInC", SqlDbType.VarChar, 10).Value = DDUInC.Trim
        '        oCmd.Parameters.Add("@DDURemarks", SqlDbType.VarChar, 100).Value = DDURemarks.Trim

        '        oCmd.Parameters.Add("@SandQty", SqlDbType.Int, 4).Value = Val(SandQty)
        '        oCmd.Parameters.Add("@SandInC", SqlDbType.VarChar, 10).Value = SandInC.Trim
        '        oCmd.Parameters.Add("@SandRemarks", SqlDbType.VarChar, 100).Value = SandRemarks.Trim

        '        oCmd.Parameters.Add("@PTQty", SqlDbType.Int, 4).Value = Val(PTQty)
        '        oCmd.Parameters.Add("@PTInC", SqlDbType.VarChar, 10).Value = PTInC.Trim
        '        oCmd.Parameters.Add("@PTRemarks", SqlDbType.VarChar, 100).Value = PTRemarks.Trim

        '        oCmd.Parameters.Add("@MPO1", SqlDbType.VarChar, 1).Value = MPO1
        '        oCmd.Parameters.Add("@MPO2", SqlDbType.VarChar, 1).Value = MPO2
        '        oCmd.Parameters.Add("@MPO3", SqlDbType.VarChar, 1).Value = MPO3

        '        oCmd.Parameters.Add("@BucketsQty", SqlDbType.Int, 4).Value = Val(BucketsQty)
        '        oCmd.Parameters.Add("@BucketsInC", SqlDbType.VarChar, 10).Value = BucketsInC.Trim
        '        oCmd.Parameters.Add("@BucketsRemarks", SqlDbType.VarChar, 100).Value = BucketsRemarks.Trim

        '        If oCmd.ExecuteNonQuery = 1 Then Done = True
        '    Catch exp As Exception
        '        Throw New Exception(exp.Message)
        '    Finally
        '        If Not IsNothing(oCmd) Then
        '            If Done Then
        '                oCmd.Transaction.Commit()
        '            Else
        '                oCmd.Transaction.Rollback()
        '            End If
        '            If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
        '            oCmd.Dispose()
        '            oCmd = Nothing
        '        End If
        '    End Try
        '    strInsert = Nothing
        '    strUpdate = Nothing
        '    Return Done
        'End Function
        'Public Function SaveSandParameters(ByVal sand_date As Date, ByVal shift_code As String, ByVal operator_id As String, ByVal resin_supplier As String, ByVal batch As String, ByVal hexa_powder_percentage As Decimal, ByVal wet_mull_time As String, ByVal dry_mull_time As String, ByVal hexa_solution_percentage As Decimal, ByVal capacitrol_set_point As Decimal, ByVal resin_in_percentage As Decimal, ByVal Resin_in_kg As Decimal, ByVal free_water As Decimal, ByVal dried_sand_in_kgs As Decimal, ByVal HexaSupp As String, ByVal resin_others_suppliers As String, ByVal hexa_others_suppliers As String, ByVal remarks As String) As Boolean
        '    Dim cmd As New SqlClient.SqlCommand()
        '    cmd.Connection = rwfGen.Connection.ConObj
        '    cmd.Parameters.Add("@sand_date", SqlDbType.SmallDateTime, 4).Value = sand_date
        '    cmd.Parameters.Add("@shift_code", SqlDbType.VarChar, 1).Value = shift_code
        '    cmd.Parameters.Add("@resin_supplier", SqlDbType.VarChar, 50).Value = resin_supplier
        '    cmd.Parameters.Add("@batch", SqlDbType.VarChar, 10).Value = batch
        '    cmd.Parameters.Add("@operator_id", SqlDbType.VarChar, 10).Value = operator_id
        '    cmd.Parameters.Add("@hexa_powder_percentage", SqlDbType.Float, 8).Value = hexa_powder_percentage
        '    cmd.Parameters.Add("@wet_mull_time", SqlDbType.VarChar, 50).Value = wet_mull_time
        '    cmd.Parameters.Add("@dry_mull_time", SqlDbType.VarChar, 50).Value = dry_mull_time
        '    cmd.Parameters.Add("@hexa_solution_percentage", SqlDbType.Float, 8).Value = hexa_solution_percentage
        '    cmd.Parameters.Add("@capacitrol_set_point", SqlDbType.Float, 8).Value = capacitrol_set_point
        '    cmd.Parameters.Add("@resin_in_percentage", SqlDbType.Float, 8).Value = resin_in_percentage
        '    cmd.Parameters.Add("@Resin_in_kg", SqlDbType.Float, 8).Value = Resin_in_kg
        '    cmd.Parameters.Add("@free_water", SqlDbType.Float, 8).Value = free_water
        '    cmd.Parameters.Add("@dried_sand_in_kgs", SqlDbType.Float, 8).Value = dried_sand_in_kgs
        '    cmd.Parameters.Add("@hexamin_supplier", SqlDbType.VarChar, 50).Value = HexaSupp
        '    cmd.Parameters.Add("@cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output
        '    cmd.Parameters.Add("@resin_others_suppliers", SqlDbType.VarChar, 50).Value = resin_others_suppliers
        '    cmd.Parameters.Add("@hexa_others_suppliers", SqlDbType.VarChar, 50).Value = hexa_others_suppliers
        '    cmd.Parameters.Add("@remarks", SqlDbType.VarChar, 50).Value = remarks
        '    Dim blnDone As Boolean
        '    Try
        '        cmd.Connection.Open()
        '        cmd.Transaction = cmd.Connection.BeginTransaction
        '        cmd.CommandText = "select @cnt = count(sample_batch_number) from mm_sand_system  " & _
        '        " where sand_date = @sand_date and sample_batch_number = @batch "
        '        cmd.ExecuteScalar()
        '        If IIf(IsDBNull(cmd.Parameters("@cnt").Value), 0, cmd.Parameters("@cnt").Value) = 0 Then
        '            cmd.CommandText = "insert into mm_sand_system ( sand_date , shift_code , sample_batch_number , " & _
        '                " resin_supplier , operator_id , hexa_powder_percentage , wet_mull_time , dry_mull_time , hexa_solution_percentage ,  " & _
        '                " capacitrol_set_point , resin_in_percentage , Resin_in_kg , " & _
        '                " free_water , dried_sand_in_kgs , hexamin_supplier , resin_others_suppliers , hexa_others_suppliers , remarks ) " & _
        '                " values ( @sand_date , @shift_code , @batch , @resin_supplier , " & _
        '                " @operator_id , @hexa_powder_percentage , @wet_mull_time, @dry_mull_time , @hexa_solution_percentage , " & _
        '                " @capacitrol_set_point , @resin_in_percentage , @Resin_in_kg , @free_water , @dried_sand_in_kgs , @hexamin_supplier , " & _
        '                " @resin_others_suppliers , @hexa_others_suppliers , @remarks ) "
        '        Else
        '            cmd.CommandText = "update mm_sand_system set resin_supplier = @resin_supplier , " & _
        '                " hexa_powder_percentage = @hexa_powder_percentage , wet_mull_time = @wet_mull_time , " & _
        '                " dry_mull_time = @dry_mull_time , hexa_solution_percentage = @hexa_solution_percentage ,  " & _
        '                " capacitrol_set_point = @capacitrol_set_point , resin_in_percentage = @resin_in_percentage , " & _
        '                " Resin_in_kg = @Resin_in_kg , free_water = @free_water , dried_sand_in_kgs = @dried_sand_in_kgs , " & _
        '                " hexamin_supplier = @hexamin_supplier , resin_others_suppliers = @resin_others_suppliers , " & _
        '                " hexa_others_suppliers = @hexa_others_suppliers , remarks = @remarks " & _
        '                " where sand_date =  @sand_date and sample_batch_number = @batch  "
        '        End If
        '        If cmd.ExecuteNonQuery() = 1 Then blnDone = True
        '    Catch exp As Exception
        '        Throw New Exception("Initialisation failure. " & exp.Message)
        '    Finally
        '        If IsNothing(cmd.Transaction) = False Then
        '            If blnDone = False Then
        '                cmd.Transaction.Rollback()
        '            Else
        '                cmd.Transaction.Commit()
        '            End If
        '        End If
        '        If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        '        cmd.Dispose()
        '        cmd = Nothing
        '    End Try
        '    Return blnDone
        'End Function

        Public Function OutTurn(ByVal OutTurnDate As Date, ByVal Shift As String, ByVal ShiftInC As String, ByVal SW1Qty As Integer, ByVal SW1InC As String, ByVal SW1Remarks As String, ByVal SW2Qty As Integer, ByVal SW2InC As String, ByVal SW2Remarks As String, ByVal SW3Qty As Integer, ByVal SW3InC As String, ByVal SW3Remarks As String, ByVal SW4Qty As Integer, ByVal SW4InC As String, ByVal SW4Remarks As String, ByVal SW5Qty As Integer, ByVal SW5InC As String, ByVal SW5Remarks As String, ByVal SW6Qty As Integer, ByVal SW6InC As String, ByVal SW6Remarks As String, ByVal SW7Qty As Integer, ByVal SW7InC As String, ByVal SW7Remarks As String, ByVal SW8Qty As Integer, ByVal SW8InC As String, ByVal SW8Remarks As String, ByVal SGM1Qty As Integer, ByVal SGM1InC As String, ByVal SGM1Remarks As String, ByVal SGM2Qty As Integer, ByVal SGM2InC As String, ByVal SGM2Remarks As String, ByVal SGM3Qty As Integer, ByVal SGM3InC As String, ByVal SGM3Remarks As String, ByVal SGM4Qty As Integer, ByVal SGM4InC As String, ByVal SGM4REmarks As String, ByVal HCM1Qty As Integer, ByVal HCM1InC As String, ByVal HCM1Remarks As String, ByVal HCM2Qty As Integer, ByVal HCM2InC As String, ByVal HCM2Remarks As String, ByVal HCM3Qty As Integer, ByVal HCM3InC As String, ByVal HCM3Remarks As String, ByVal CBQty As Integer, ByVal CBInC As String, ByVal CBRemarks As String, ByVal CSQty As Integer, ByVal CSInC As String, ByVal CSRemarks As String, ByVal DSQty As Integer, ByVal DSInC As String, ByVal DSRemarks As String, ByVal COLQty As Integer, ByVal COLInC As String, ByVal COLRemarks As String, ByVal DOLQty As Integer, ByVal DOLInC As String, ByVal DOLRemarks As String, ByVal WhlsCast As Integer, ByVal MROffLoad As Integer, ByVal SWLess400 As Integer, ByVal HCLess250 As Integer, ByVal CSGr230 As Integer, ByVal CSLess170 As Integer, ByVal DSGr230 As Integer, ByVal DSLess170 As Integer, ByVal SWRecSts As String, ByVal HCRecSts As String, ByVal CSRecSts As String, ByVal DSRecSts As String, ByVal RK1BrushSts As String, ByVal RK2BrushSts As String, ByVal C5IE As String, ByVal C5IW As String, ByVal C5KE As String, ByVal C5KW As String, ByVal SWCQty As Integer, ByVal SWCInC As String, ByVal SWCRemarks As String, ByVal SWPGQty As Integer, ByVal SWPGInC As String, ByVal SWPGRemarks As String, ByVal NBDQty As Integer, ByVal NBDInC As String, ByVal NBDRemarks As String, ByVal DDUQty As Integer, ByVal DDUInC As String, ByVal DDURemarks As String, ByVal CopesQty As Integer, ByVal CopesInC As String, ByVal CopesRemarks As String, ByVal DragsQty As Integer, ByVal DragsInC As String, ByVal DragsRemarks As String, ByVal CopesMQty As Integer, ByVal CopesMInC As String, ByVal CopesMRemarks As String, ByVal DragsMQty As Integer, ByVal DragsMInC As String, ByVal DragsMRemarks As String, ByVal SandQty As Integer, ByVal SandInC As String, ByVal SandRemarks As String, ByVal PTQty As Integer, ByVal PTInC As String, ByVal PTRemarks As String, ByVal MPO1 As String, ByVal MPO2 As String, ByVal MPO3 As String) As Boolean
            Dim blnInsert As Boolean
            Dim ds As New DataSet()
            Try
                ds = RWF.MLDING.CheckOutTurn(CDate(OutTurnDate), Shift)
                If ds.Tables(0).Rows.Count = 0 Then
                    blnInsert = True
                End If
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                ds.Dispose()
                ds = Nothing
            End Try
            Dim oCmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            Dim Done As Boolean
            Dim strInsert, strUpdate As String
            Try
                oCmd.Parameters.Add("@OutTurnDate", SqlDbType.SmallDateTime, 4).Value = CDate(OutTurnDate)
                oCmd.Parameters.Add("@Shift", SqlDbType.VarChar, 1).Value = Shift

                'strInsert = " insert into mm_MROutTurn ( OutTurnDate,Shift,WhlsCast , MROffLoad , SW1Qty,SW1InC,SW1Remarks,SW2Qty,SW2InC,SW2Remarks,SW3Qty," & _
                '            " SW3InC,SW3Remarks,SW4Qty,SW4InC,SW4Remarks,SW5Qty,SW5InC,SW5Remarks,SW6Qty," & _
                '            " SW6InC,SW6Remarks,SW7Qty,SW7InC,SW7Remarks,SW8Qty,SW8InC,SW8Remarks,SGM1Qty," & _
                '            " SGM1InC,SGM1Remarks,SGM2Qty,SGM2InC,SGM2Remarks,SGM3Qty,SGM3InC,SGM3Remarks," & _
                '            " SGM4Qty,SGM4InC,SGM4REmarks,HCM1Qty,HCM1InC,HCM1Remarks,HCM2Qty,HCM2InC," & _
                '            " HCM2Remarks,HCM3Qty,HCM3InC,HCM3Remarks,HCM4Qty,HCM4InC,HCM4Remarks,HCM5Qty," & _
                '            " HCM5InC,HCM5Remarks,NFCQty,NFCInC,NFCRemarks,NFDQty,NFDInC,NFDRemarks," & _
                '            " DFDQty, DFDInC, DFDRemarks, CBQty, CBInC, CBRemarks, " & _
                '            " CSQty,CSInC,CSRemarks,DSQty,DSInC,DSRemarks,COLQty,COLInC, " & _
                '            " COLRemarks, DOLQty, DOLInC, DOLRemarks, ShiftInC , " & _
                '            " SWLess400 , HCLess250 , CSGr230 , CSLess170 , DSGr230 , DSLess170 , SWRecSts , " & _
                '            " HCRecSts , CSRecSts , DSRecSts , RK1BrushSts , RK2BrushSts , C5IE , C5IW , C5KE , C5KW ,  " & _
                '            " SWCQty , SWCInC  , SWCRemarks  , SWPGQty  , SWPGInC  , SWPGRemarks , " & _
                '            " NBDQty , NBDInC , NBDRemarks , DDUQty , DDUInC , DDURemarks , " & _
                '            " CopesQty , CopesInC , CopesRemarks  , DragsQty  , DragsInC  , DragsRemarks , " & _
                '            " SandQty   , SandInC , SandRemarks , PTQty  , PTInC   , PTRemarks   , MPO1  , MPO2  , MPO3 , " & _
                '            " BucketsQty , BucketsInC , BucketsRemarks ) " & _
                '            " values ( @OutTurnDate,@Shift,@WhlsCast , @MROffLoad , @SW1Qty,@SW1InC,@SW1Remarks,@SW2Qty,@SW2InC,@SW2Remarks,@SW3Qty," & _
                '            " @SW3InC,@SW3Remarks,@SW4Qty,@SW4InC,@SW4Remarks,@SW5Qty,@SW5InC,@SW5Remarks,@SW6Qty," & _
                '            " @SW6InC,@SW6Remarks,@SW7Qty,@SW7InC,@SW7Remarks,@SW8Qty,@SW8InC,@SW8Remarks,@SGM1Qty," & _
                '            " @SGM1InC,@SGM1Remarks,@SGM2Qty,@SGM2InC,@SGM2Remarks,@SGM3Qty,@SGM3InC,@SGM3Remarks," & _
                '            " @SGM4Qty,@SGM4InC,@SGM4REmarks,@HCM1Qty,@HCM1InC,@HCM1Remarks,@HCM2Qty,@HCM2InC," & _
                '            " @HCM2Remarks,@HCM3Qty,@HCM3InC,@HCM3Remarks,@HCM4Qty,@HCM4InC,@HCM4Remarks,@HCM5Qty," & _
                '            " @HCM5InC,@HCM5Remarks,@NFCQty,@NFCInC,@NFCRemarks,@NFDQty,@NFDInC,@NFDRemarks," & _
                '            " @DFDQty, @DFDInC, @DFDRemarks, @CBQty, @CBInC, @CBRemarks, " & _
                '            " @CSQty,@CSInC,@CSRemarks,@DSQty,@DSInC,@DSRemarks,@COLQty,@COLInC, " & _
                '            " @COLRemarks, @DOLQty, @DOLInC, @DOLRemarks, @ShiftInC , " & _
                '            " @SWLess400 , @HCLess250 , @CSGr230 , @CSLess170 , @DSGr230 , @DSLess170 , @SWRecSts , " & _
                '            " @HCRecSts , @CSRecSts , @DSRecSts , @RK1BrushSts , @RK2BrushSts , @C5IE , @C5IW , @C5KE , @C5KW , " & _
                '            " @SWCQty , @SWCInC , @SWCRemarks , @SWPGQty , @SWPGInC , @SWPGRemarks ," & _
                '            " @NBDQty , @NBDInC , @NBDRemarks , @DDUQty , @DDUInC , @DDURemarks , " & _
                '            " @CopesQty , @CopesInC , @CopesRemarks  , @DragsQty  , @DragsInC  , @DragsRemarks , " & _
                '            " @SandQty   , @SandInC , @SandRemarks , @PTQty  , @PTInC   , @PTRemarks   , @MPO1  , @MPO2  , @MPO3 , " & _
                '            " @BucketsQty , @BucketsInC , @BucketsRemarks ) "

                strInsert = " insert into mm_MROutTurnNew ( OutTurnDate,Shift,WhlsCast , MROffLoad , SW1Qty,SW1InC,SW1Remarks,SW2Qty,SW2InC,SW2Remarks,SW3Qty," &
                            " SW3InC,SW3Remarks,SW4Qty,SW4InC,SW4Remarks,SW5Qty,SW5InC,SW5Remarks,SW6Qty," &
                            " SW6InC,SW6Remarks,SW7Qty,SW7InC,SW7Remarks,SW8Qty,SW8InC,SW8Remarks,SGM1Qty," &
                            " SGM1InC,SGM1Remarks,SGM2Qty,SGM2InC,SGM2Remarks,SGM3Qty,SGM3InC,SGM3Remarks," &
                            " SGM4Qty,SGM4InC,SGM4REmarks,HCM1Qty,HCM1InC,HCM1Remarks,HCM2Qty,HCM2InC," &
                            " HCM2Remarks,HCM3Qty,HCM3InC,HCM3Remarks,CBQty, CBInC, CBRemarks," &
                            " CSQty,CSInC,CSRemarks,DSQty,DSInC,DSRemarks,COLQty,COLInC, " &
                            " COLRemarks, DOLQty, DOLInC, DOLRemarks, ShiftInC , " &
                            " SWLess400 , HCLess250 , CSGr230 , CSLess170 , DSGr230 , DSLess170 , SWRecSts , " &
                            " HCRecSts , CSRecSts , DSRecSts , RK1BrushSts , RK2BrushSts , C5IE , C5IW , C5KE , C5KW ,  " &
                            " SWCQty , SWCInC  , SWCRemarks  , SWPGQty  , SWPGInC  , SWPGRemarks , " &
                            " NBDQty , NBDInC , NBDRemarks , DDUQty , DDUInC , DDURemarks , " &
                            " CopesQty , CopesInC , CopesRemarks  , DragsQty  , DragsInC  , DragsRemarks , " &
                            " CopesMQty , CopesMInC , CopesMRemarks  , DragsMQty  , DragsMInC  , DragsMRemarks , " &
                            " SandQty   , SandInC , SandRemarks , PTQty  , PTInC   , PTRemarks   , MPO1  , MPO2  , MPO3 ) " &
                            " values ( @OutTurnDate,@Shift,@WhlsCast , @MROffLoad , @SW1Qty,@SW1InC,@SW1Remarks,@SW2Qty,@SW2InC,@SW2Remarks,@SW3Qty," &
                            " @SW3InC,@SW3Remarks,@SW4Qty,@SW4InC,@SW4Remarks,@SW5Qty,@SW5InC,@SW5Remarks,@SW6Qty," &
                            " @SW6InC,@SW6Remarks,@SW7Qty,@SW7InC,@SW7Remarks,@SW8Qty,@SW8InC,@SW8Remarks,@SGM1Qty," &
                            " @SGM1InC,@SGM1Remarks,@SGM2Qty,@SGM2InC,@SGM2Remarks,@SGM3Qty,@SGM3InC,@SGM3Remarks," &
                            " @SGM4Qty,@SGM4InC,@SGM4REmarks,@HCM1Qty,@HCM1InC,@HCM1Remarks,@HCM2Qty,@HCM2InC," &
                            " @HCM2Remarks,@HCM3Qty,@HCM3InC,@HCM3Remarks,@CBQty, @CBInC, @CBRemarks," &
                            " @CSQty,@CSInC,@CSRemarks,@DSQty,@DSInC,@DSRemarks,@COLQty,@COLInC, " &
                            " @COLRemarks, @DOLQty, @DOLInC, @DOLRemarks, @ShiftInC , " &
                            " @SWLess400 , @HCLess250 , @CSGr230 , @CSLess170 , @DSGr230 , @DSLess170 , @SWRecSts , " &
                            " @HCRecSts , @CSRecSts , @DSRecSts , @RK1BrushSts , @RK2BrushSts , @C5IE , @C5IW , @C5KE , @C5KW , " &
                            " @SWCQty , @SWCInC , @SWCRemarks , @SWPGQty , @SWPGInC , @SWPGRemarks ," &
                            " @NBDQty , @NBDInC , @NBDRemarks , @DDUQty , @DDUInC , @DDURemarks , " &
                            " @CopesQty , @CopesInC , @CopesRemarks  , @DragsQty  , @DragsInC  , @DragsRemarks , " &
                               " @CopesMQty , @CopesMInC , @CopesMRemarks  , @DragsMQty  , @DragsMInC  , @DragsMRemarks , " &
                            " @SandQty   , @SandInC , @SandRemarks , @PTQty  , @PTInC   , @PTRemarks   , @MPO1  , @MPO2  , @MPO3) "



                'strUpdate = " update mm_MROutTurn set WhlsCast = @WhlsCast ,  MROffLoad = @MROffLoad , SW1Qty = @SW1Qty, SW1InC = @SW1InC ,SW1Remarks = @SW1Remarks , SW2Qty = @SW2Qty ," & _
                '            " SW2InC = @SW2InC , SW2Remarks = @SW2Remarks , SW3Qty = @SW3Qty , " & _
                '            " SW3InC   =  @SW3InC ,  SW3Remarks   =  @SW3Remarks ,  SW4Qty   =  @SW4Qty ,  SW4InC   =  @SW4InC ," & _
                '            " SW4Remarks   =  @SW4Remarks ,  SW5Qty   =  @SW5Qty ,  SW5InC   =  @SW5InC ,  SW5Remarks   =  @SW5Remarks , " & _
                '            " SW6Qty   =  @SW6Qty ,  SW6InC   = @SW6InC  ,  SW6Remarks   =  @SW6Remarks " & _
                '            ",  SW7Qty   = @SW7Qty   " & _
                '            " , SW7InC   =  @SW7InC ,  SW7Remarks   =  @SW7Remarks " & _
                '            " ,  SW8Qty   =  @SW8Qty ,  SW8InC   = @SW8InC ,  " & _
                '            " SW8Remarks   =  @SW8Remarks ,  SGM1Qty   = @SGM1Qty  ,  SGM1InC   = @SGM1InC ,  SGM1Remarks   = @SGM1Remarks , " & _
                '            " SGM2Qty   =  @SGM2Qty ,  SGM2InC   = @SGM2InC ,  SGM2Remarks   = @SGM2Remarks ,  SGM3Qty   = @SGM3Qty ,  " & _
                '            " SGM3InC   =  @SGM3InC ,  SGM3Remarks   =  @SGM3Remarks , SGM4Qty   = @SGM4Qty  ,  SGM4InC   = @SGM4InC ,  " & _
                '            " SGM4REmarks   =  @SGM4REmarks " & _
                '            " ,  HCM1Qty   = @HCM1Qty  ,  HCM1InC   =  @HCM1InC ,  HCM1Remarks   =  @HCM1Remarks, " & _
                '            " HCM2Qty   =  @HCM2Qty ,  HCM2InC   = @HCM2InC ,  HCM2Remarks   =  @HCM2Remarks ,  HCM3Qty   = @HCM3Qty ,  " & _
                '            " HCM3InC   =  @HCM3InC ,  HCM3Remarks   = @HCM3Remarks  ,  HCM4Qty   = @HCM4Qty  ,  HCM4InC   =  @HCM4InC,  " & _
                '            " HCM4Remarks   =  @HCM4Remarks ,  HCM5Qty   =  @HCM5Qty ,  HCM5InC   = @HCM5InC ,  HCM5Remarks   =  @HCM5Remarks , " & _
                '            " NFCQty   =  @NFCQty ,  NFCInC   = @NFCInC ,  NFCRemarks   = @NFCRemarks ,  NFDQty   = @NFDQty ,  " & _
                '            " NFDInC   =  @NFDInC ,  NFDRemarks   = @NFDRemarks ,  DFDQty   =  @DFDQty,  DFDInC   = @DFDInC ,  " & _
                '            " DFDRemarks   =  @DFDRemarks ,  CBQty   =  @CBQty ,  CBInC   = @CBInC ,  CBRemarks   = @CBRemarks , " & _
                '            " CSQty   = @CSQty ,  CSInC   = @CSInC ,  CSRemarks   = @CSRemarks ,  DSQty   = @DSQty ,  " & _
                '            " DSInC   = @DSInC ,  DSRemarks   =  @DSRemarks  " & _
                '            " , COLQty = @COLQty , COLInC = @COLInC , COLRemarks = @COLRemarks " & _
                '            " , DOLQty   = @DOLQty ,  DOLInC   = @DOLInC ,  DOLRemarks   =  @DOLRemarks ,  ShiftInC = @ShiftInC " & _
                '            " , SWLess400 = @SWLess400 , HCLess250 = @HCLess250 , CSGr230 = @CSGr230 ,  " & _
                '            " CSLess170 = @CSLess170 , DSGr230 = @DSGr230 , DSLess170 = @DSLess170 ,  " & _
                '            " SWRecSts = @SWRecSts , HCRecSts = @HCRecSts , CSRecSts = @CSRecSts ,  " & _
                '            " DSRecSts = @DSRecSts , RK1BrushSts = @RK1BrushSts , RK2BrushSts = @RK2BrushSts ,  " & _
                '            " C5IE = @C5IE , C5IW = @C5IW , C5KE = @C5KE , C5KW = @C5KW , " & _
                '            " SWCQty = @SWCQty , SWCInC  = @SWCInC , SWCRemarks = @SWCRemarks  , SWPGQty = @SWPGQty  , SWPGInC = @SWPGInC , SWPGRemarks  = @SWPGRemarks , " & _
                '            " NBDQty = @NBDQty , NBDInC = @NBDInC , NBDRemarks = @NBDRemarks , DDUQty = @DDUQty , DDUInC  = @DDUInC , DDURemarks = @DDURemarks , " & _
                '            " CopesQty = @CopesQty , CopesInC = @CopesInC , CopesRemarks = @CopesRemarks , " & _
                '            " DragsQty = @DragsQty , DragsInC = @DragsInC , DragsRemarks = @DragsRemarks , " & _
                '            " SandQty = @SandQty ,  SandInC = @SandInC , SandRemarks = @SandRemarks , " & _
                '            " PTQty = @PTQty , PTInC = @PTInC , PTRemarks = @PTRemarks , " & _
                '            " MPO1 = @MPO1 , MPO2 = @MPO2 , MPO3  = @MPO3 , BucketsQty = @BucketsQty , BucketsInC = @BucketsInC , BucketsRemarks = @BucketsRemarks " & _
                '            " where OutTurnDate = @OutTurnDate and Shift = @Shift "

                strUpdate = " update mm_MROutTurnNew set WhlsCast = @WhlsCast ,  MROffLoad = @MROffLoad , SW1Qty = @SW1Qty, SW1InC = @SW1InC ,SW1Remarks = @SW1Remarks , SW2Qty = @SW2Qty ," &
                            " SW2InC = @SW2InC , SW2Remarks = @SW2Remarks , SW3Qty = @SW3Qty , " &
                            " SW3InC   =  @SW3InC ,  SW3Remarks   =  @SW3Remarks ,  SW4Qty   =  @SW4Qty ,  SW4InC   =  @SW4InC ," &
                            " SW4Remarks   =  @SW4Remarks ,  SW5Qty   =  @SW5Qty ,  SW5InC   =  @SW5InC ,  SW5Remarks   =  @SW5Remarks , " &
                            " SW6Qty   =  @SW6Qty ,  SW6InC   = @SW6InC  ,  SW6Remarks   =  @SW6Remarks ,  SW7Qty   = @SW7Qty,   " &
                            " SW7InC   =  @SW7InC ,  SW7Remarks   =  @SW7Remarks,  SW8Qty   =  @SW8Qty ,  SW8InC   = @SW8InC ,  " &
                            " SW8Remarks   =  @SW8Remarks ,  SGM1Qty   = @SGM1Qty  ,  SGM1InC   = @SGM1InC ,  SGM1Remarks   = @SGM1Remarks , " &
                            " SGM2Qty   =  @SGM2Qty ,  SGM2InC   = @SGM2InC ,  SGM2Remarks   = @SGM2Remarks ,  SGM3Qty   = @SGM3Qty ,  " &
                            " SGM3InC   =  @SGM3InC ,  SGM3Remarks   =  @SGM3Remarks , SGM4Qty   = @SGM4Qty  ,  SGM4InC   = @SGM4InC ,  " &
                            " SGM4REmarks   =  @SGM4REmarks,  HCM1Qty   = @HCM1Qty  ,  HCM1InC   =  @HCM1InC ,  HCM1Remarks   =  @HCM1Remarks, " &
                            " HCM2Qty   =  @HCM2Qty ,  HCM2InC   = @HCM2InC ,  HCM2Remarks   =  @HCM2Remarks ,  HCM3Qty   = @HCM3Qty ,  " &
                            " HCM3InC   =  @HCM3InC ,  HCM3Remarks   = @HCM3Remarks  , CBQty =  @CBQty ,  CBInC   = @CBInC ,  CBRemarks   = @CBRemarks , " &
                            " CBQty   =  @CBQty ,  CBInC   = @CBInC ,  CBRemarks   = @CBRemarks , " &
                            " CSQty   = @CSQty ,  CSInC   = @CSInC ,  CSRemarks   = @CSRemarks ,  DSQty   = @DSQty ,  " &
                            " DSInC   = @DSInC ,  DSRemarks   =  @DSRemarks, COLQty = @COLQty , COLInC = @COLInC , COLRemarks = @COLRemarks, " &
                            " DOLQty   = @DOLQty ,  DOLInC   = @DOLInC ,  DOLRemarks   =  @DOLRemarks ,  ShiftInC = @ShiftInC, " &
                            " SWLess400 = @SWLess400 , HCLess250 = @HCLess250 , CSGr230 = @CSGr230 ,CSLess170 = @CSLess170 , DSGr230 = @DSGr230 ,   " &
                            " DSLess170 = @DSLess170 ,SWRecSts = @SWRecSts , HCRecSts = @HCRecSts , CSRecSts = @CSRecSts ,  " &
                            " DSRecSts = @DSRecSts , RK1BrushSts = @RK1BrushSts , RK2BrushSts = @RK2BrushSts ,  " &
                            " C5IE = @C5IE , C5IW = @C5IW , C5KE = @C5KE , C5KW = @C5KW , " &
                            " SWCQty = @SWCQty , SWCInC  = @SWCInC , SWCRemarks = @SWCRemarks  , SWPGQty = @SWPGQty  , SWPGInC = @SWPGInC , SWPGRemarks  = @SWPGRemarks , " &
                            " NBDQty = @NBDQty , NBDInC = @NBDInC , NBDRemarks = @NBDRemarks , DDUQty = @DDUQty , DDUInC  = @DDUInC , DDURemarks = @DDURemarks , " &
                            " CopesQty = @CopesQty , CopesInC = @CopesInC , CopesRemarks = @CopesRemarks , " &
                            " DragsQty = @DragsQty , DragsInC = @DragsInC , DragsRemarks = @DragsRemarks , " &
                            " CopesMQty = @CopesMQty , CopesMInC = @CopesMInC , CopesMRemarks = @CopesMRemarks , " &
                            " DragsMQty = @DragsMQty , DragsMInC = @DragsMInC , DragsMRemarks = @DragsMRemarks , " &
                            " SandQty = @SandQty ,  SandInC = @SandInC , SandRemarks = @SandRemarks , " &
                            " PTQty = @PTQty , PTInC = @PTInC , PTRemarks = @PTRemarks , MPO1 = @MPO1 , MPO2 = @MPO2 , MPO3  = @MPO3   " &
                            " where OutTurnDate = @OutTurnDate and Shift = @Shift "

                If oCmd.Connection.State = ConnectionState.Closed Then oCmd.Connection.Open()
                oCmd.Transaction = oCmd.Connection.BeginTransaction
                If blnInsert Then
                    oCmd.CommandText = strInsert
                Else
                    oCmd.CommandText = strUpdate
                End If
                oCmd.Parameters.Add("@ShiftInC", SqlDbType.VarChar, 10).Value = ShiftInC
                oCmd.Parameters.Add("@SW1Qty", SqlDbType.Int, 4).Value = Val(SW1Qty)
                oCmd.Parameters.Add("@SW1InC", SqlDbType.VarChar, 10).Value = SW1InC
                oCmd.Parameters.Add("@SW1Remarks", SqlDbType.VarChar, 100).Value = SW1Remarks
                oCmd.Parameters.Add("@SW2Qty", SqlDbType.Int, 4).Value = Val(SW2Qty)
                oCmd.Parameters.Add("@SW2InC", SqlDbType.VarChar, 10).Value = SW2InC
                oCmd.Parameters.Add("@SW2Remarks", SqlDbType.VarChar, 100).Value = SW2Remarks
                oCmd.Parameters.Add("@SW3Qty", SqlDbType.Int, 4).Value = Val(SW3Qty)
                oCmd.Parameters.Add("@SW3InC", SqlDbType.VarChar, 10).Value = SW3InC
                oCmd.Parameters.Add("@SW3Remarks", SqlDbType.VarChar, 100).Value = SW3Remarks
                oCmd.Parameters.Add("@SW4Qty", SqlDbType.Int, 4).Value = Val(SW4Qty)
                oCmd.Parameters.Add("@SW4InC", SqlDbType.VarChar, 10).Value = SW4InC
                oCmd.Parameters.Add("@SW4Remarks", SqlDbType.VarChar, 100).Value = SW4Remarks
                oCmd.Parameters.Add("@SW5Qty", SqlDbType.Int, 4).Value = Val(SW5Qty)
                oCmd.Parameters.Add("@SW5InC", SqlDbType.VarChar, 10).Value = SW5InC
                oCmd.Parameters.Add("@SW5Remarks", SqlDbType.VarChar, 100).Value = SW5Remarks
                oCmd.Parameters.Add("@SW6Qty", SqlDbType.Int, 4).Value = Val(SW6Qty)
                oCmd.Parameters.Add("@SW6InC", SqlDbType.VarChar, 10).Value = SW6InC
                oCmd.Parameters.Add("@SW6Remarks", SqlDbType.VarChar, 100).Value = SW6Remarks
                oCmd.Parameters.Add("@SW7Qty", SqlDbType.Int, 4).Value = Val(SW7Qty)
                oCmd.Parameters.Add("@SW7InC", SqlDbType.VarChar, 10).Value = SW7InC
                oCmd.Parameters.Add("@SW7Remarks", SqlDbType.VarChar, 100).Value = SW7Remarks
                oCmd.Parameters.Add("@SW8Qty", SqlDbType.Int, 4).Value = Val(SW8Qty)
                oCmd.Parameters.Add("@SW8InC", SqlDbType.VarChar, 10).Value = SW8InC
                oCmd.Parameters.Add("@SW8Remarks", SqlDbType.VarChar, 100).Value = SW8Remarks
                oCmd.Parameters.Add("@SGM1Qty", SqlDbType.Int, 4).Value = Val(SGM1Qty)
                oCmd.Parameters.Add("@SGM1InC", SqlDbType.VarChar, 10).Value = SGM1InC
                oCmd.Parameters.Add("@SGM1Remarks", SqlDbType.VarChar, 100).Value = SGM1Remarks
                oCmd.Parameters.Add("@SGM2Qty", SqlDbType.Int, 4).Value = Val(SGM2Qty)
                oCmd.Parameters.Add("@SGM2InC", SqlDbType.VarChar, 10).Value = SGM2InC
                oCmd.Parameters.Add("@SGM2Remarks", SqlDbType.VarChar, 100).Value = SGM2Remarks
                oCmd.Parameters.Add("@SGM3Qty", SqlDbType.Int, 4).Value = Val(SGM3Qty)
                oCmd.Parameters.Add("@SGM3InC", SqlDbType.VarChar, 10).Value = SGM3InC
                oCmd.Parameters.Add("@SGM3Remarks", SqlDbType.VarChar, 100).Value = SGM3Remarks
                oCmd.Parameters.Add("@SGM4Qty", SqlDbType.Int, 4).Value = Val(SGM4Qty)
                oCmd.Parameters.Add("@SGM4InC", SqlDbType.VarChar, 10).Value = SGM4InC
                oCmd.Parameters.Add("@SGM4REmarks", SqlDbType.VarChar, 100).Value = SGM4REmarks
                oCmd.Parameters.Add("@HCM1Qty", SqlDbType.Int, 4).Value = Val(HCM1Qty)
                oCmd.Parameters.Add("@HCM1InC", SqlDbType.VarChar, 10).Value = HCM1InC
                oCmd.Parameters.Add("@HCM1Remarks", SqlDbType.VarChar, 100).Value = HCM1Remarks
                oCmd.Parameters.Add("@HCM2Qty", SqlDbType.Int, 4).Value = Val(HCM2Qty)
                oCmd.Parameters.Add("@HCM2InC", SqlDbType.VarChar, 10).Value = HCM2InC
                oCmd.Parameters.Add("@HCM2Remarks", SqlDbType.VarChar, 100).Value = HCM2Remarks
                oCmd.Parameters.Add("@HCM3Qty", SqlDbType.Int, 4).Value = Val(HCM3Qty)
                oCmd.Parameters.Add("@HCM3InC", SqlDbType.VarChar, 10).Value = HCM3InC
                oCmd.Parameters.Add("@HCM3Remarks", SqlDbType.VarChar, 100).Value = HCM3Remarks
                'oCmd.Parameters.Add("@HCM4Qty", SqlDbType.Int, 4).Value = Val(HCM4Qty)
                'oCmd.Parameters.Add("@HCM4InC", SqlDbType.VarChar, 10).Value = HCM4InC
                'oCmd.Parameters.Add("@HCM4Remarks", SqlDbType.VarChar, 100).Value = HCM4Remarks
                'oCmd.Parameters.Add("@HCM5Qty", SqlDbType.Int, 4).Value = Val(HCM5Qty)
                'oCmd.Parameters.Add("@HCM5InC", SqlDbType.VarChar, 10).Value = HCM5InC
                'oCmd.Parameters.Add("@HCM5Remarks", SqlDbType.VarChar, 100).Value = HCM5Remarks
                'oCmd.Parameters.Add("@NFCQty", SqlDbType.Int, 4).Value = Val(NFCQty)
                'oCmd.Parameters.Add("@NFCInC", SqlDbType.VarChar, 10).Value = NFCInC
                'oCmd.Parameters.Add("@NFCRemarks", SqlDbType.VarChar, 100).Value = NFCRemarks
                'oCmd.Parameters.Add("@NFDQty", SqlDbType.Int, 4).Value = Val(NFDQty)
                'oCmd.Parameters.Add("@NFDInC", SqlDbType.VarChar, 10).Value = NFDInC
                'oCmd.Parameters.Add("@NFDRemarks", SqlDbType.VarChar, 100).Value = NFDRemarks
                'oCmd.Parameters.Add("@DFDQty", SqlDbType.Int, 4).Value = Val(DFDQty)
                'oCmd.Parameters.Add("@DFDInC", SqlDbType.VarChar, 10).Value = DFDInC
                'oCmd.Parameters.Add("@DFDRemarks", SqlDbType.VarChar, 100).Value = DFDRemarks
                oCmd.Parameters.Add("@CBQty", SqlDbType.Int, 4).Value = Val(CBQty)
                oCmd.Parameters.Add("@CBInC", SqlDbType.VarChar, 10).Value = CBInC
                oCmd.Parameters.Add("@CBRemarks", SqlDbType.VarChar, 100).Value = CBRemarks
                oCmd.Parameters.Add("@CSQty", SqlDbType.Int, 4).Value = Val(CSQty)
                oCmd.Parameters.Add("@CSInC", SqlDbType.VarChar, 10).Value = CSInC
                oCmd.Parameters.Add("@CSRemarks", SqlDbType.VarChar, 100).Value = CSRemarks
                oCmd.Parameters.Add("@DSQty", SqlDbType.Int, 4).Value = Val(DSQty)
                oCmd.Parameters.Add("@DSInC", SqlDbType.VarChar, 10).Value = DSInC
                oCmd.Parameters.Add("@DSRemarks", SqlDbType.VarChar, 100).Value = DSRemarks
                oCmd.Parameters.Add("@COLQty", SqlDbType.Int, 4).Value = Val(COLQty)
                oCmd.Parameters.Add("@COLInC", SqlDbType.VarChar, 10).Value = COLInC
                oCmd.Parameters.Add("@COLRemarks", SqlDbType.VarChar, 100).Value = COLRemarks
                oCmd.Parameters.Add("@DOLQty", SqlDbType.Int, 4).Value = Val(DOLQty)
                oCmd.Parameters.Add("@DOLInC", SqlDbType.VarChar, 10).Value = DOLInC
                oCmd.Parameters.Add("@DOLRemarks", SqlDbType.VarChar, 100).Value = DOLRemarks
                oCmd.Parameters.Add("@WhlsCast", SqlDbType.Int, 4).Value = Val(WhlsCast)
                oCmd.Parameters.Add("@MROffLoad", SqlDbType.Int, 4).Value = Val(MROffLoad)
                oCmd.Parameters.Add("@SWLess400", SqlDbType.Int, 4).Value = Val(SWLess400)
                oCmd.Parameters.Add("@HCLess250", SqlDbType.Int, 4).Value = Val(HCLess250)
                oCmd.Parameters.Add("@CSGr230", SqlDbType.Int, 4).Value = Val(CSGr230)
                oCmd.Parameters.Add("@CSLess170", SqlDbType.Int, 4).Value = Val(CSLess170)
                oCmd.Parameters.Add("@DSGr230", SqlDbType.Int, 4).Value = Val(DSGr230)
                oCmd.Parameters.Add("@DSLess170", SqlDbType.Int, 4).Value = Val(DSLess170)
                oCmd.Parameters.Add("@SWRecSts", SqlDbType.VarChar, 100).Value = SWRecSts
                oCmd.Parameters.Add("@HCRecSts", SqlDbType.VarChar, 100).Value = HCRecSts
                oCmd.Parameters.Add("@CSRecSts", SqlDbType.VarChar, 100).Value = CSRecSts
                oCmd.Parameters.Add("@DSRecSts", SqlDbType.VarChar, 100).Value = DSRecSts
                oCmd.Parameters.Add("@RK1BrushSts", SqlDbType.VarChar, 100).Value = RK1BrushSts
                oCmd.Parameters.Add("@RK2BrushSts", SqlDbType.VarChar, 100).Value = RK2BrushSts
                oCmd.Parameters.Add("@C5IE", SqlDbType.VarChar, 100).Value = C5IE
                oCmd.Parameters.Add("@C5IW", SqlDbType.VarChar, 100).Value = C5IW
                oCmd.Parameters.Add("@C5KE", SqlDbType.VarChar, 100).Value = C5KE
                oCmd.Parameters.Add("@C5KW", SqlDbType.VarChar, 100).Value = C5KW
                oCmd.Parameters.Add("@SWCQty", SqlDbType.Int, 4).Value = Val(SWCQty)
                oCmd.Parameters.Add("@SWCInC", SqlDbType.VarChar, 10).Value = SWCInC
                oCmd.Parameters.Add("@SWCRemarks", SqlDbType.VarChar, 100).Value = SWCRemarks
                oCmd.Parameters.Add("@SWPGQty", SqlDbType.Int, 4).Value = Val(SWPGQty)
                oCmd.Parameters.Add("@SWPGInC", SqlDbType.VarChar, 10).Value = SWPGInC
                oCmd.Parameters.Add("@SWPGRemarks", SqlDbType.VarChar, 100).Value = SWPGRemarks

                oCmd.Parameters.Add("@NBDQty", SqlDbType.Int, 4).Value = Val(NBDQty)
                oCmd.Parameters.Add("@NBDInC", SqlDbType.VarChar, 10).Value = NBDInC.Trim
                oCmd.Parameters.Add("@NBDRemarks", SqlDbType.VarChar, 100).Value = NBDRemarks.Trim

                oCmd.Parameters.Add("@CopesQty", SqlDbType.Int, 4).Value = Val(CopesQty)
                oCmd.Parameters.Add("@CopesInC", SqlDbType.VarChar, 10).Value = CopesInC.Trim
                oCmd.Parameters.Add("@CopesRemarks", SqlDbType.VarChar, 100).Value = CopesRemarks.Trim

                oCmd.Parameters.Add("@DragsQty", SqlDbType.Int, 4).Value = Val(DragsQty)
                oCmd.Parameters.Add("@DragsInC", SqlDbType.VarChar, 10).Value = DragsInC.Trim
                oCmd.Parameters.Add("@DragsRemarks", SqlDbType.VarChar, 100).Value = DragsRemarks.Trim

                oCmd.Parameters.Add("@CopesMQty", SqlDbType.Int, 4).Value = Val(CopesQty)
                oCmd.Parameters.Add("@CopesMInC", SqlDbType.VarChar, 10).Value = CopesInC.Trim
                oCmd.Parameters.Add("@CopesMRemarks", SqlDbType.VarChar, 100).Value = CopesRemarks.Trim

                oCmd.Parameters.Add("@DragsMQty", SqlDbType.Int, 4).Value = Val(DragsQty)
                oCmd.Parameters.Add("@DragsMInC", SqlDbType.VarChar, 10).Value = DragsInC.Trim
                oCmd.Parameters.Add("@DragsMRemarks", SqlDbType.VarChar, 100).Value = DragsRemarks.Trim

                oCmd.Parameters.Add("@DDUQty", SqlDbType.Int, 4).Value = Val(DDUQty)
                oCmd.Parameters.Add("@DDUInC", SqlDbType.VarChar, 10).Value = DDUInC.Trim
                oCmd.Parameters.Add("@DDURemarks", SqlDbType.VarChar, 100).Value = DDURemarks.Trim

                oCmd.Parameters.Add("@SandQty", SqlDbType.Int, 4).Value = Val(SandQty)
                oCmd.Parameters.Add("@SandInC", SqlDbType.VarChar, 10).Value = SandInC.Trim
                oCmd.Parameters.Add("@SandRemarks", SqlDbType.VarChar, 100).Value = SandRemarks.Trim

                oCmd.Parameters.Add("@PTQty", SqlDbType.Int, 4).Value = Val(PTQty)
                oCmd.Parameters.Add("@PTInC", SqlDbType.VarChar, 10).Value = PTInC.Trim
                oCmd.Parameters.Add("@PTRemarks", SqlDbType.VarChar, 100).Value = PTRemarks.Trim

                oCmd.Parameters.Add("@MPO1", SqlDbType.VarChar, 1).Value = MPO1
                oCmd.Parameters.Add("@MPO2", SqlDbType.VarChar, 1).Value = MPO2
                oCmd.Parameters.Add("@MPO3", SqlDbType.VarChar, 1).Value = MPO3

                'oCmd.Parameters.Add("@BucketsQty", SqlDbType.Int, 4).Value = Val(BucketsQty)
                'oCmd.Parameters.Add("@BucketsInC", SqlDbType.VarChar, 10).Value = BucketsInC.Trim
                'oCmd.Parameters.Add("@BucketsRemarks", SqlDbType.VarChar, 100).Value = BucketsRemarks.Trim

                If oCmd.ExecuteNonQuery = 1 Then Done = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If Not IsNothing(oCmd) Then
                    If Done Then
                        oCmd.Transaction.Commit()
                    Else
                        oCmd.Transaction.Rollback()
                    End If
                    If oCmd.Connection.State = ConnectionState.Open Then oCmd.Connection.Close()
                    oCmd.Dispose()
                    oCmd = Nothing
                End If
            End Try
            strInsert = Nothing
            strUpdate = Nothing
            Return Done
        End Function
        Public Function PostAsMRXC(ByVal Whl As Double, ByVal Ht As Double, ByVal Change As String) As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj

            cmd.Parameters.Add("@Whl", SqlDbType.BigInt, 8).Value = Whl
            cmd.Parameters.Add("@Ht", SqlDbType.BigInt, 8).Value = Ht
            cmd.Parameters.Add("@Change", SqlDbType.VarChar, 50).Value = Change
            cmd.Parameters.Add("@remarks", SqlDbType.VarChar, 50).Value = "PostedByMagna"
            Dim blnDone As Boolean
            Dim Fail As Boolean
            Try
                cmd.Connection.Open()
                cmd.Transaction = cmd.Connection.BeginTransaction
                cmd.CommandText = " update mm_wheel" & _
                    " set workorder_cleaning_room = null , status = @Change ," & _
                    " location = 'MOPO' , magnaglow_status = null , " & _
                    " bhn_rate = null , ut_status = null , bhn_status = null" & _
                    " where heat_number = @Ht And wheel_number = @Whl "
                If cmd.ExecuteNonQuery() > 0 Then
                    cmd.CommandText = "update mm_pouring" & _
                        " set rejection_code = @Change , remarks = @remarks , PostedDateTime = getdate()" & _
                        " where heat_number = @Ht and engraved_number = @Whl "
                    If cmd.ExecuteNonQuery() > 0 Then
                        cmd.CommandText = " update mm_post_pouring " & _
                            " set total_wheels_poured = ( total_wheels_poured -1) " & _
                            " where heat_number = @Ht "
                        If cmd.ExecuteNonQuery() > 0 Then blnDone = True
                    End If
                End If
            Catch exp As Exception
                Fail = True
                Throw New Exception(exp.Message)
            Finally
                If Not Fail Then
                    If IsNothing(cmd.Transaction) = False Then
                        If blnDone = False Then
                            cmd.Transaction.Rollback()
                        Else
                            cmd.Transaction.Commit()
                        End If
                    End If
                End If
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            Return blnDone
        End Function
        Public Function ChangeMagnaXCToMRXC(ByVal Whl As Double, ByVal Ht As Double, ByVal Change As String, ByVal remarks As String) As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj

            cmd.Parameters.Add("@Whl", SqlDbType.BigInt, 8).Value = Whl
            cmd.Parameters.Add("@Ht", SqlDbType.BigInt, 8).Value = Ht
            cmd.Parameters.Add("@Change", SqlDbType.VarChar, 50).Value = Change
            cmd.Parameters.Add("@remarks", SqlDbType.VarChar, 50).Value = remarks
            Dim blnDone As Boolean
            Try
                cmd.Connection.Open()
                cmd.Transaction = cmd.Connection.BeginTransaction
                cmd.CommandText = " update mm_wheel" & _
                    " set workorder_cleaning_room = null , status = @Change , " & _
                    " location = 'MOPO' , magnaglow_status = null , " & _
                    " bhn_rate = null , ut_status = null , bhn_status = null" & _
                    " where heat_number = @Ht And wheel_number = @Whl "
                If cmd.ExecuteNonQuery() > 0 Then
                    cmd.CommandText = "update mm_pouring" & _
                        " set rejection_code = @Change , remarks = @remarks " & _
                        " where heat_number = @Ht and engraved_number = @Whl "
                    If cmd.ExecuteNonQuery() > 0 Then
                        cmd.CommandText = "delete a" & _
                            " from mm_magnaglow_results_SaveTime a inner join mm_magnaglow_results b" & _
                            " on a.sl_no = b.sl_no " & _
                            " where heat_number = @Ht And wheel_number = @Whl "
                        If cmd.ExecuteNonQuery() > 0 Then
                            cmd.CommandText = "delete from mm_magnaglow_results" & _
                                " where heat_number = @Ht And wheel_number = @Whl "
                            If cmd.ExecuteNonQuery() > 0 Then
                                cmd.CommandText = "insert into mm_magnaglow_shiftwiserecords_Deleted" & _
                                    " select * , 'ChangeToMRXC' , getdate() ,  @remarks " & _
                                    " from mm_magnaglow_shiftwiserecords" & _
                                    " where heatnumber = @Ht and wheelnumber = @Whl "
                                If cmd.ExecuteNonQuery() > 0 Then
                                    cmd.CommandText = "delete from mm_magnaglow_shiftwiserecords" & _
                                        " where heatnumber = @Ht and wheelnumber = @Whl "
                                    If cmd.ExecuteNonQuery() > 0 Then blnDone = True
                                    cmd.CommandText = "delete from mm_wheel_machining_details " & _
                                        " where heat_number = @Ht And wheel_number = @Whl "
                                    cmd.ExecuteNonQuery()
                                    cmd.CommandText = " update mm_post_pouring " & _
                                        " set total_wheels_poured = ( total_wheels_poured -1) " & _
                                        " where heat_number = @Ht "
                                    cmd.ExecuteNonQuery()
                                End If
                            End If
                        End If
                    End If
                End If
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If IsNothing(cmd.Transaction) = False Then
                    If blnDone = False Then
                        cmd.Transaction.Rollback()
                    Else
                        cmd.Transaction.Commit()
                    End If
                End If
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            Return blnDone
        End Function
        Public Function MRShiftDetailsNewData(ByVal FrHt As Double, ByVal ToHt As Double) As DataTable
            Dim blnDone As Boolean
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "select  Sl , Item , o1st , " & _
                    " o2nd , o3rd , o4th , o5th , o6th , o7th , o8th , o9th , o10th     " & _
                    " from mm_MRShiftDetailsNew where FrHt = @FrHt and ToHt = @ToHt "

                da.SelectCommand.Parameters.Add("@FrHt", SqlDbType.BigInt, 8).Value = FrHt
                da.SelectCommand.Parameters.Add("@ToHt", SqlDbType.BigInt, 8).Value = ToHt

                da.Fill(ds)
                Return ds.Tables(0)
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
        End Function
        Public Function MRShiftDetailsNew(ByVal FrHt As Double, ByVal ToHt As Double) As Boolean
            Dim blnDone As Boolean
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "mm_sp_MRShiftDetailsDataNew"
                da.SelectCommand.Parameters.Add("@FrHt", SqlDbType.BigInt, 8).Value = FrHt
                da.SelectCommand.Parameters.Add("@ToHt", SqlDbType.BigInt, 8).Value = ToHt
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then blnDone = True
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
            Return blnDone
        End Function
        Public Function MRShiftDetails(ByVal TappedDate As Date, ByVal TappedShift As String) As Boolean
            Dim blnDone As Boolean
            Dim ds As New DataSet()
            Dim da As SqlClient.SqlDataAdapter = rwfGen.Connection.Adapter
            Try
                da.SelectCommand.CommandText = "mm_sp_MRShiftDetailsData"
                da.SelectCommand.Parameters.Add("@TappedDate", SqlDbType.SmallDateTime, 4).Value = CDate(TappedDate)
                da.SelectCommand.Parameters.Add("@TappedShift", SqlDbType.VarChar, 1).Value = TappedShift
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    da.SelectCommand.CommandText = "mm_sp_MROutTurnShiftWiseData"
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.Fill(ds)
                    If ds.Tables(0).Rows.Count > 0 Then
                        da.SelectCommand.CommandText = "mm_sp_MROnLineMouldData"
                        da.SelectCommand.CommandType = CommandType.StoredProcedure
                        da.Fill(ds)
                        If ds.Tables(0).Rows.Count > 0 Then
                            da.SelectCommand.CommandText = "mm_sp_MRMouldRemoverFromLineData"
                            da.SelectCommand.CommandType = CommandType.StoredProcedure
                            da.Fill(ds)
                            If ds.Tables(0).Rows.Count > 0 Then
                                da.SelectCommand.CommandText = "mm_sp_MagnaOffLoadsShiftWiseData"
                                da.SelectCommand.CommandType = CommandType.StoredProcedure
                                da.Fill(ds)
                                If ds.Tables(0).Rows.Count > 0 Then
                                    da.SelectCommand.CommandText = "mm_sp_MagnaOutTurnShiftWiseData"
                                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                                    da.Fill(ds)
                                    If ds.Tables(0).Rows.Count > 0 Then blnDone = True
                                End If
                            End If
                        End If
                    End If
                End If
            Catch exp As Exception
                Throw New Exception("Data Retrieval Error : " & exp.Message)
            Finally
                da.Dispose()
                ds.Dispose()
                ds = Nothing
                da = Nothing
            End Try
            Return blnDone
        End Function
        Public Function WheelNFLoading(ByVal loading_date As Date, ByVal shift_code As String, ByVal operator_code As String, ByVal supervisor As String, ByVal wheel_number As Integer, ByVal heat_number As Long, ByVal pedestral_number As String, ByVal charge_in_time As DateTime, ByVal charge_out_time As DateTime, ByVal offload_code As String, ByVal quenched_number As String, ByVal temperature_on_discharge As Integer, ByVal remarks As String, ByVal quenching_duration As String, ByVal hubcooling_duration As String, ByVal Cold As Int16, Optional ByVal Sl_No As Long = 0) As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj

            cmd.Parameters.Add("@loading_date", SqlDbType.SmallDateTime, 4).Value = loading_date
            cmd.Parameters.Add("@shift_code", SqlDbType.VarChar, 1).Value = shift_code
            cmd.Parameters.Add("@operator_code", SqlDbType.VarChar, 50).Value = operator_code
            cmd.Parameters.Add("@supervisor", SqlDbType.VarChar, 50).Value = supervisor
            cmd.Parameters.Add("@wheel_number", SqlDbType.Int, 4).Value = wheel_number
            cmd.Parameters.Add("@heat_number", SqlDbType.BigInt, 8).Value = heat_number
            cmd.Parameters.Add("@pedestral_number", SqlDbType.VarChar, 10).Value = pedestral_number
            cmd.Parameters.Add("@charge_in_time", SqlDbType.DateTime, 8).Value = charge_in_time
            cmd.Parameters.Add("@charge_out_time", SqlDbType.DateTime, 8).Value = charge_out_time
            cmd.Parameters.Add("@offload_code", SqlDbType.VarChar, 8).Value = offload_code
            cmd.Parameters.Add("@quenched_number", SqlDbType.VarChar, 8).Value = quenched_number
            cmd.Parameters.Add("@temperature_on_discharge", SqlDbType.Float, 8).Value = temperature_on_discharge
            cmd.Parameters.Add("@remarks", SqlDbType.VarChar, 50).Value = remarks
            cmd.Parameters.Add("@quenching_duration", SqlDbType.VarChar, 50).Value = quenching_duration
            cmd.Parameters.Add("@hubcooling_duration", SqlDbType.VarChar, 50).Value = hubcooling_duration
            cmd.Parameters.Add("@SaveDateTime", SqlDbType.DateTime, 8).Value = Now
            cmd.Parameters.Add("@Cold", SqlDbType.Int, 4).Value = Cold
            cmd.Parameters.Add("@Sl_No", SqlDbType.BigInt, 8).Direction = ParameterDirection.Output
            cmd.Parameters.Add("@NFTemp", SqlDbType.VarChar, 2).Direction = ParameterDirection.Input
            Dim NFTemp As String
            Dim NF As Int16
            Try
                If charge_out_time.Minute <= 45 Then
                    NF = charge_out_time.Hour
                Else
                    charge_out_time = charge_out_time.AddHours(1)
                    NF = charge_out_time.Hour
                End If
                NFTemp = "0" + CStr(NF)
                cmd.Parameters("@NFTemp").Value = Left(NFTemp, 2)
            Catch exp As Exception
                Throw New Exception(exp.Message)
            End Try

            Dim blnDone As Boolean
            Try
                cmd.Connection.Open()
                cmd.Transaction = cmd.Connection.BeginTransaction
                cmd.CommandText = " select @sl_no = isnull(sl_no,0) from mm_normalizing_furnace_loading " & _
                    " where loading_date = @loading_date and shift_code = @shift_code " & _
                    " and wheel_number = @wheel_number and heat_number = @heat_number "
                cmd.ExecuteScalar()
                cmd.Parameters("@Sl_No").Direction = ParameterDirection.Input
                If IIf(IsDBNull(cmd.Parameters("@Sl_No").Value), 0, cmd.Parameters("@Sl_No").Value) = 0 Then
                    cmd.CommandText = " insert into mm_normalizing_furnace_loading ( loading_date , shift_code , " & _
                        " operator_code , supervisor , wheel_number , heat_number , pedestral_number , " & _
                        " charge_in_time , charge_out_time , offload_code , quenched_number , " & _
                        " temperature_on_discharge , remarks , quenching_duration , hubcooling_duration , NFTemp , Cold )" & _
                        " values ( @loading_date , @shift_code , @operator_code , @supervisor , @wheel_number , " & _
                        " @heat_number , @pedestral_number , @charge_in_time , @charge_out_time , @offload_code , " & _
                        " @quenched_number , @temperature_on_discharge , @remarks , @quenching_duration , " & _
                        " @hubcooling_duration , @NFTemp , @Cold ) "
                Else
                    cmd.CommandText = " update mm_normalizing_furnace_loading set" & _
                    " operator_code = @operator_code , supervisor = @supervisor , " & _
                    " pedestral_number = @pedestral_number , charge_in_time = @charge_in_time ," & _
                    " charge_out_time = @charge_out_time , offload_code = @offload_code , " & _
                    " quenched_number = @quenched_number , temperature_on_discharge = @temperature_on_discharge , " & _
                    " remarks = @remarks , quenching_duration = @quenching_duration , SaveDateTime = @SaveDateTime , " & _
                    " hubcooling_duration = @hubcooling_duration , NFTemp = @NFTemp , Cold = @Cold " & _
                    " where loading_date = @loading_date and shift_code = @shift_code and" & _
                    " wheel_number = @wheel_number and heat_number = @heat_number and Sl_No = @Sl_No "
                End If
                If cmd.ExecuteNonQuery = 1 Then blnDone = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If IsNothing(cmd.Transaction) = False Then
                    If blnDone = False Then
                        cmd.Transaction.Rollback()
                    Else
                        cmd.Transaction.Commit()
                    End If
                End If
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            NFTemp = Nothing
            NF = Nothing
            Return blnDone
        End Function
        Public Function WheelNFTempData(ByVal nf_date As Date, ByVal shift_code As String, ByVal operator_code As String, ByVal superviosr As String, ByVal NFTime As String, ByVal Z2 As Integer, ByVal Z3 As Integer, ByVal Z4 As Integer, ByVal Z5 As Integer, ByVal Z6 As Integer, ByVal Z7 As Integer, ByVal Com As Integer, ByVal Flu As Integer, ByVal REMARKS As String) As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj

            cmd.Parameters.Add("@nf_date", SqlDbType.SmallDateTime, 4).Value = nf_date
            cmd.Parameters.Add("@shift_code", SqlDbType.VarChar, 1).Value = shift_code
            cmd.Parameters.Add("@operator_code", SqlDbType.VarChar, 50).Value = operator_code
            cmd.Parameters.Add("@superviosr", SqlDbType.VarChar, 50).Value = superviosr
            cmd.Parameters.Add("@temerature_reading_time", SqlDbType.VarChar, 5).Value = NFTime
            cmd.Parameters.Add("@Z2", SqlDbType.Int, 4).Value = Z2
            cmd.Parameters.Add("@Z3", SqlDbType.Int, 4).Value = Z3
            cmd.Parameters.Add("@Z4", SqlDbType.Int, 4).Value = Z4
            cmd.Parameters.Add("@Z5", SqlDbType.Int, 4).Value = Z5
            cmd.Parameters.Add("@Z6", SqlDbType.Int, 4).Value = Z6
            cmd.Parameters.Add("@Z7", SqlDbType.Int, 4).Value = Z7
            cmd.Parameters.Add("@Com", SqlDbType.Int, 4).Value = Com
            cmd.Parameters.Add("@Flu", SqlDbType.Int, 4).Value = Flu
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 50).Value = REMARKS
            cmd.Parameters.Add("@SaveDateTime", SqlDbType.DateTime, 8).Value = Now
            cmd.Parameters.Add("@Sl_No", SqlDbType.BigInt, 8).Direction = ParameterDirection.Output
            Dim blnDone As Boolean
            Try
                cmd.Connection.Open()
                cmd.Transaction = cmd.Connection.BeginTransaction
                cmd.CommandText = " select @sl_no = isnull(sl_no,0) from mm_normalising_furnace_temperature " & _
                    " where nf_date = @nf_date and temerature_reading_time = @temerature_reading_time "
                cmd.ExecuteScalar()
                cmd.ExecuteScalar()
                cmd.Parameters("@Sl_No").Direction = ParameterDirection.Input
                If IIf(IsDBNull(cmd.Parameters("@Sl_No").Value), 0, cmd.Parameters("@Sl_No").Value) = 0 Then
                    cmd.CommandText = " insert into mm_normalising_furnace_temperature ( nf_date , shift_code , " & _
                        " operator_code , superviosr , temerature_reading_time , temperature_zone2 , " & _
                        " temperature_zone3 , temperature_zone4 , temperature_zone5 , temperature_zone6 , temperature_zone7  ,   " & _
                        " combustion_gas , flue_gas , remarks , SaveDateTime ) " & _
                        " values ( @nf_date , @shift_code , @operator_code , @superviosr ,  @temerature_reading_time , " & _
                        " @Z2 , @Z3 , @Z4 , @Z5 , @Z6 , @Z7 , @Com , @Flu , @remarks , @SaveDateTime )"
                Else
                    cmd.CommandText = " update mm_normalising_furnace_temperature" & _
                    " set superviosr = @superviosr , operator_code = @operator_code , " & _
                    " temperature_zone2 = @Z2 , temperature_zone3 = @Z3 , temperature_zone4 = @Z4 , " & _
                    " temperature_zone5 = @Z5 ,  temperature_zone6 = @Z6 , temperature_zone7 = @Z7 , " & _
                    " combustion_gas = @Com , flue_gas = @Flu , Remarks = @Remarks " & _
                    " where nf_date = @nf_date and shift_code = @shift_code and " & _
                    " temerature_reading_time = @temerature_reading_time and Sl_No = @Sl_No "
                End If
                If cmd.ExecuteNonQuery = 1 Then blnDone = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If IsNothing(cmd.Transaction) = False Then
                    If blnDone = False Then
                        cmd.Transaction.Rollback()
                    Else
                        cmd.Transaction.Commit()
                    End If
                End If
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            Return blnDone
        End Function
        Public Function WheelDFTempData(ByVal df_date As Date, ByVal shift_code As String, ByVal operator_code As String, ByVal superviosr As String, ByVal NFTime As String, ByVal Z1 As Integer, ByVal Z2 As Integer, ByVal Z3 As Integer, ByVal Z4 As Integer, ByVal Z5 As Integer, ByVal Z6 As Integer, ByVal Z7 As Integer, ByVal Z8 As Integer, ByVal REMARKS As String) As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj

            cmd.Parameters.Add("@df_date", SqlDbType.SmallDateTime, 4).Value = df_date
            cmd.Parameters.Add("@shift_code", SqlDbType.VarChar, 1).Value = shift_code
            cmd.Parameters.Add("@operator_code", SqlDbType.VarChar, 50).Value = operator_code
            cmd.Parameters.Add("@superviosr", SqlDbType.VarChar, 50).Value = superviosr
            cmd.Parameters.Add("@temerature_reading_time", SqlDbType.VarChar, 5).Value = NFTime
            cmd.Parameters.Add("@Z1", SqlDbType.Int, 4).Value = Z1
            cmd.Parameters.Add("@Z2", SqlDbType.Int, 4).Value = Z2
            cmd.Parameters.Add("@Z3", SqlDbType.Int, 4).Value = Z3
            cmd.Parameters.Add("@Z4", SqlDbType.Int, 4).Value = Z4
            cmd.Parameters.Add("@Z5", SqlDbType.Int, 4).Value = Z5
            cmd.Parameters.Add("@Z6", SqlDbType.Int, 4).Value = Z6
            cmd.Parameters.Add("@Z7", SqlDbType.Int, 4).Value = Z7
            cmd.Parameters.Add("@Z8", SqlDbType.Int, 4).Value = Z8
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 50).Value = REMARKS
            cmd.Parameters.Add("@SaveDateTime", SqlDbType.DateTime, 8).Value = Now
            cmd.Parameters.Add("@Sl_No", SqlDbType.BigInt, 8).Direction = ParameterDirection.Output
            Dim blnDone As Boolean
            Try
                cmd.Connection.Open()
                cmd.Transaction = cmd.Connection.BeginTransaction
                cmd.CommandText = " select @sl_no = isnull(sl_no,0) from mm_draw_furnace_temperatures " & _
                    " where df_date = @df_date and temerature_reading_time = @temerature_reading_time "
                cmd.ExecuteScalar()
                cmd.ExecuteScalar()
                cmd.Parameters("@Sl_No").Direction = ParameterDirection.Input
                If IIf(IsDBNull(cmd.Parameters("@Sl_No").Value), 0, cmd.Parameters("@Sl_No").Value) = 0 Then
                    cmd.CommandText = " insert into mm_draw_furnace_temperatures ( df_date , shift_code , " & _
                        " operator_code , superviosr , temerature_reading_time , temperature_zone1 , temperature_zone2 , " & _
                        " temperature_zone3 , temperature_zone4 , temperature_zone5 , temperature_zone6 , temperature_zone7  ,   " & _
                        " temperature_zone8 , remarks , SaveDateTime ) " & _
                        " values ( @df_date , @shift_code , @operator_code , @superviosr ,  @temerature_reading_time , " & _
                        " @Z1 , @Z2 , @Z3 , @Z4 , @Z5 , @Z6 , @Z7 , @Z8 , @remarks , @SaveDateTime )"
                Else
                    cmd.CommandText = " update mm_draw_furnace_temperatures" & _
                    " set superviosr = @superviosr , operator_code = @operator_code , " & _
                    " temperature_zone1 = @Z1 , temperature_zone2 = @Z2 , " & _
                    " temperature_zone3 = @Z3 , temperature_zone4 = @Z4 , temperature_zone5 = @Z5 , " & _
                    " temperature_zone6 = @Z6 , temperature_zone7 = @Z7 , temperature_zone8 = @Z8 , Remarks = @Remarks " & _
                    " where df_date = @df_date and shift_code = @shift_code and " & _
                    " temerature_reading_time = @temerature_reading_time and Sl_No = @Sl_No "
                End If
                If cmd.ExecuteNonQuery = 1 Then blnDone = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If IsNothing(cmd.Transaction) = False Then
                    If blnDone = False Then
                        cmd.Transaction.Rollback()
                    Else
                        cmd.Transaction.Commit()
                    End If
                End If
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            Return blnDone
        End Function
        Public Function PouringTubes(ByVal heat_number As Double, ByVal TubeNo As String, ByVal TopSide As String, ByVal MiddleSide As String, ByVal BottomSide As String, ByVal Remarks As String) As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj
            cmd.Parameters.Add("@Sl_No", SqlDbType.BigInt, 8).Direction = ParameterDirection.Output
            cmd.Parameters.Add("@heat_number", SqlDbType.BigInt, 8).Value = heat_number
            cmd.Parameters.Add("@TubeNo", SqlDbType.VarChar, 50).Value = TubeNo
            cmd.Parameters.Add("@TopSide", SqlDbType.VarChar, 50).Value = TopSide
            cmd.Parameters.Add("@MiddleSide", SqlDbType.VarChar, 50).Value = MiddleSide
            cmd.Parameters.Add("@BottomSide", SqlDbType.VarChar, 50).Value = BottomSide
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 50).Value = Remarks

            Dim blnDone As Boolean
            Try
                cmd.Connection.Open()
                cmd.Transaction = cmd.Connection.BeginTransaction
                cmd.CommandText = " select @sl_no = count(*) from mm_pouring_tube " & _
                    " where heat_number = @heat_number and TubeNo = @TubeNo "
                cmd.ExecuteScalar()
                cmd.Parameters("@Sl_No").Direction = ParameterDirection.Input
                If IIf(IsDBNull(cmd.Parameters("@Sl_No").Value), 0, cmd.Parameters("@Sl_No").Value) = 0 Then
                    cmd.CommandText = " insert into mm_pouring_tube " & _
                        " ( heat_number , TubeNo , TopSide , MiddleSide , BottomSide , Remarks ) " & _
                        " values ( @heat_number , @TubeNo , @TopSide , @MiddleSide , @BottomSide , @Remarks )"
                Else
                    cmd.CommandText = " update mm_pouring_tube" & _
                    " set TopSide = @TopSide , MiddleSide = @MiddleSide , " & _
                    " BottomSide = @BottomSide , Remarks = @Remarks " & _
                    " where heat_number = @heat_number and TubeNo = @TubeNo  "
                End If
                If cmd.ExecuteNonQuery = 1 Then blnDone = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If IsNothing(cmd.Transaction) = False Then
                    If blnDone = False Then
                        cmd.Transaction.Rollback()
                    Else
                        cmd.Transaction.Commit()
                    End If
                End If
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            Return blnDone
        End Function
        Public Function MROffloadWheels(ByVal HeatNo As Double, ByVal WheelNo As String, ByVal TypeID As Integer, ByVal SIC As String, ByVal OffCode As String, ByVal PresentCode As String, ByVal Remarks As String, ByVal PresentStsDate As Date, ByVal PresentSIC As String, Optional ByVal RecID As String = "") As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj
            cmd.Parameters.Add("@OffID", SqlDbType.BigInt, 8).Direction = ParameterDirection.Output
            cmd.Parameters.Add("@HeatNo", SqlDbType.BigInt, 8).Value = HeatNo
            cmd.Parameters.Add("@WheelNo", SqlDbType.VarChar, 50).Value = WheelNo
            cmd.Parameters.Add("@TypeID", SqlDbType.Int, 4).Value = TypeID
            cmd.Parameters.Add("@SIC", SqlDbType.VarChar, 50).Value = SIC
            cmd.Parameters.Add("@OffCode", SqlDbType.VarChar, 50).Value = OffCode
            cmd.Parameters.Add("@PresentCode", SqlDbType.VarChar, 50).Value = PresentCode
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 50).Value = Remarks
            cmd.Parameters.Add("@PresentStsDate", SqlDbType.SmallDateTime, 4).Value = PresentStsDate '
            cmd.Parameters.Add("@PresentSIC", SqlDbType.VarChar, 50).Value = PresentSIC

            Dim blnDone As Boolean
            Try
                cmd.Connection.Open()
                cmd.Transaction = cmd.Connection.BeginTransaction
                If WheelNo = 0 And RecID.Trim.Length > 0 Then
                    cmd.CommandText = " insert into mm_MROffloadWheels " &
                    " ( HeatNo , WheelNo , TypeID , OffCode , PresentStsDate  ) " &
                    " select @Heat_Number, engraved_number  , @TypeID , @OffCode , @PresentStsDate " &
                    " from mm_pouring  where heat_number = @Heat_Number and engraved_number in " & "(" & RecID.Trim & ")"

                Else
                    cmd.CommandText = " select @OffID = OffID from mm_MROffloadWheels " &
                                        " where HeatNo = @HeatNo and WheelNo = @WheelNo "
                    cmd.ExecuteScalar()
                    cmd.Parameters("@OffID").Direction = ParameterDirection.Input
                    If IIf(IsDBNull(cmd.Parameters("@OffID").Value), 0, cmd.Parameters("@OffID").Value) = 0 Then
                        cmd.CommandText = " insert into mm_MROffloadWheels " &
                            " ( HeatNo , WheelNo , TypeID , SIC , OffCode , PresentCode , Remarks , PresentStsDate , PresentSIC ) " &
                            " values ( @HeatNo , @WheelNo , @TypeID , @SIC , @OffCode , @PresentCode , @Remarks , @PresentStsDate , @PresentSIC )"
                    Else
                        cmd.CommandText = " update mm_MROffloadWheels" &
                        " set TypeID = @TypeID , SIC = @SIC , PresentCode = @PresentCode , PresentSIC = @PresentSIC , " &
                        " OffCode = @OffCode , Remarks = @Remarks , PresentStsDate = @PresentStsDate " &
                        " where HeatNo = @HeatNo and WheelNo = @WheelNo and OffID = @OffID "

                    End If
                End If
                If cmd.ExecuteNonQuery > 0 Then
                    blnDone = True
                Else
                    blnDone = False
                End If
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If IsNothing(cmd.Transaction) = False Then
                    If blnDone = False Then
                        cmd.Transaction.Rollback()
                    Else
                        cmd.Transaction.Commit()
                    End If
                End If
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            Return blnDone
        End Function

        Public Function MROffloadWheelsDelete(ByVal HeatNo As Double, ByVal WheelNo As Double) As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj
            cmd.Parameters.Add("@HeatNo", SqlDbType.BigInt, 8).Value = HeatNo
            cmd.Parameters.Add("@WheelNo", SqlDbType.BigInt, 8).Value = WheelNo

            Dim blnDone As Boolean
            Try
                cmd.Connection.Open()
                cmd.Transaction = cmd.Connection.BeginTransaction
                cmd.CommandText = " delete mm_MROffloadWheels" & _
                    " where HeatNo = @HeatNo and WheelNo = @WheelNo  "
                If cmd.ExecuteNonQuery = 1 Then blnDone = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If IsNothing(cmd.Transaction) = False Then
                    If blnDone = False Then
                        cmd.Transaction.Rollback()
                    Else
                        cmd.Transaction.Commit()
                    End If
                End If
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            Return blnDone
        End Function
        Public Function MROffloadWheelsNew(ByVal HeatNoList As DataTable, ByVal TypeID As Integer, ByVal SIC As String, ByVal OffCode As String, ByVal PresentCode As String, ByVal Remarks As String, ByVal PresentStsDate As Date, ByVal PresentSIC As String) As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj
            cmd.Parameters.Add("@OffID", SqlDbType.BigInt, 8).Direction = ParameterDirection.Output
            cmd.Parameters.Add("@HeatNo", SqlDbType.BigInt, 8).Direction = ParameterDirection.Input
            cmd.Parameters.Add("@WheelNo", SqlDbType.BigInt, 8).Direction = ParameterDirection.Input
            cmd.Parameters.Add("@TypeID", SqlDbType.Int, 4).Value = TypeID
            cmd.Parameters.Add("@SIC", SqlDbType.VarChar, 50).Value = SIC
            cmd.Parameters.Add("@OffCode", SqlDbType.VarChar, 50).Value = OffCode
            cmd.Parameters.Add("@PresentCode", SqlDbType.VarChar, 50).Value = PresentCode
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 50).Value = Remarks
            cmd.Parameters.Add("@PresentStsDate", SqlDbType.SmallDateTime, 4).Value = PresentStsDate '
            cmd.Parameters.Add("@PresentSIC", SqlDbType.VarChar, 50).Value = PresentSIC

            Dim blnDone As Boolean
            Try
                cmd.Connection.Open()
                cmd.Transaction = cmd.Connection.BeginTransaction
                Dim i As Integer
                For i = 0 To HeatNoList.Rows.Count - 1
                    cmd.Parameters("@HeatNo").Value = HeatNoList.Rows(i)(0)
                    cmd.Parameters("@WheelNo").Value = HeatNoList.Rows(i)(1)

                    cmd.CommandText = " select @OffID = OffID from mm_MROffloadWheels " & _
                        " where HeatNo = @HeatNo and WheelNo = @WheelNo "
                    cmd.ExecuteScalar()
                    cmd.Parameters("@OffID").Direction = ParameterDirection.Input
                    If IIf(IsDBNull(cmd.Parameters("@OffID").Value), 0, cmd.Parameters("@OffID").Value) = 0 Then
                        cmd.CommandText = " insert into mm_MROffloadWheels " & _
                            " ( HeatNo , WheelNo , TypeID , SIC , OffCode , PresentCode , Remarks , PresentStsDate , PresentSIC ) " & _
                            " values ( @HeatNo , @WheelNo , @TypeID , @SIC , @OffCode , @PresentCode , @Remarks , @PresentStsDate , @PresentSIC )"
                    Else
                        cmd.CommandText = " update mm_MROffloadWheels" & _
                        " set TypeID = @TypeID , SIC = @SIC , PresentCode = @PresentCode , PresentSIC = @PresentSIC , " & _
                        " OffCode = @OffCode , Remarks = @Remarks , PresentStsDate = @PresentStsDate " & _
                        " where HeatNo = @HeatNo and WheelNo = @WheelNo and OffID = @OffID "
                    End If
                    If cmd.ExecuteNonQuery = 1 Then
                        blnDone = True
                    Else
                        blnDone = False
                        Exit For
                    End If
                Next
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If IsNothing(cmd.Transaction) = False Then
                    If blnDone = False Then
                        cmd.Transaction.Rollback()
                    Else
                        cmd.Transaction.Commit()
                    End If
                End If
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            Return blnDone
        End Function

        Public Function MROffloadSingleHeatWheels(ByVal HeatNoList As DataTable, ByVal TypeID As Integer, ByVal SIC As String, ByVal OffCode As String, ByVal PresentCode As String, ByVal Remarks As String, ByVal PresentStsDate As Date, ByVal PresentSIC As String, ByVal ClearedDate As Date, Optional ByVal RecID As String = "", Optional ByVal ClearedSts As String = "", Optional ByVal ClearedSIC As String = "") As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj
            cmd.Parameters.Add("@OffID", SqlDbType.BigInt, 8).Direction = ParameterDirection.Output
            cmd.Parameters.Add("@HeatNo", SqlDbType.BigInt, 8).Direction = ParameterDirection.Input
            cmd.Parameters.Add("@WheelNo", SqlDbType.BigInt, 8).Direction = ParameterDirection.Input
            cmd.Parameters.Add("@TypeID", SqlDbType.Int, 4).Value = TypeID
            cmd.Parameters.Add("@SIC", SqlDbType.VarChar, 50).Value = SIC
            cmd.Parameters.Add("@OffCode", SqlDbType.VarChar, 50).Value = OffCode
            cmd.Parameters.Add("@PresentCode", SqlDbType.VarChar, 50).Value = PresentCode
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 50).Value = Remarks
            cmd.Parameters.Add("@PresentStsDate", SqlDbType.SmallDateTime, 4).Value = PresentStsDate '
            cmd.Parameters.Add("@PresentSIC", SqlDbType.VarChar, 50).Value = PresentSIC

            cmd.Parameters.Add("@ClearedSts", SqlDbType.VarChar, 50).Value = ClearedSts
            cmd.Parameters.Add("@ClearedDate", SqlDbType.SmallDateTime, 4).Value = ClearedDate
            cmd.Parameters.Add("@ClearedSIC", SqlDbType.VarChar, 50).Value = ClearedSIC
            Dim blnDone As Boolean
            Try
                cmd.Connection.Open()
                cmd.Transaction = cmd.Connection.BeginTransaction
                Dim i As Integer
                For i = 0 To HeatNoList.Rows.Count - 1
                    cmd.Parameters("@HeatNo").Value = HeatNoList.Rows(i)(0)
                    cmd.Parameters("@WheelNo").Value = HeatNoList.Rows(i)(1)
                    cmd.Parameters("@OffCode").Value = HeatNoList.Rows(i)(2)

                    cmd.CommandText = " select @OffID = OffID from mm_MROffloadWheels " & _
                          " where HeatNo = @HeatNo and WheelNo = @WheelNo "
                    cmd.ExecuteScalar()
                    cmd.Parameters("@OffID").Direction = ParameterDirection.Input
                    cmd.CommandText = "alter table mm_wheel disable TRIGGER mm_tr_wheel_UpdateforBackUp"
                    cmd.ExecuteNonQuery()
                    If IIf(IsDBNull(cmd.Parameters("@OffID").Value), 0, cmd.Parameters("@OffID").Value) = 0 Then
                        cmd.CommandText = " insert into mm_MROffloadWheels " & _
                            " ( HeatNo , WheelNo , TypeID , SIC , OffCode , PresentCode , Remarks , PresentStsDate , PresentSIC , ClearedSts  , ClearedDate , ClearedSIC ) " & _
                            " values ( @HeatNo , @WheelNo , @TypeID , @SIC , @OffCode , @PresentCode , @Remarks , @PresentStsDate , @PresentSIC , @ClearedSts  , @ClearedDate , @ClearedSIC )"
                    Else
                        cmd.CommandText = " update mm_MROffloadWheels" & _
                        " set TypeID = @TypeID , SIC = @SIC , PresentCode = @PresentCode , PresentSIC = @PresentSIC , " & _
                        " OffCode = @OffCode , PresentStsDate = @PresentStsDate , " & _
                        " ClearedSts  = @ClearedSts , ClearedDate = @ClearedDate , ClearedSIC = @ClearedSIC " & _
                        " where HeatNo = @HeatNo and WheelNo = @WheelNo and OffID = @OffID "
                    End If
                    If cmd.ExecuteNonQuery > 0 Then
                        blnDone = True
                    Else
                        blnDone = False
                        Exit For
                    End If
                    cmd.CommandText = "alter table mm_wheel enable TRIGGER mm_tr_wheel_UpdateforBackUp"
                    cmd.ExecuteNonQuery()
                    cmd.Parameters("@OffID").Value = 0
                    cmd.Parameters("@OffID").Direction = ParameterDirection.Output
                Next
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If IsNothing(cmd.Transaction) = False Then
                    If blnDone = False Then
                        cmd.Transaction.Rollback()
                    Else
                        cmd.Transaction.Commit()
                    End If
                End If
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            Return blnDone
        End Function
        Public Function NFOffloads(ByVal WheelList As String, ByVal HeatNo As Long, ByVal OffDate As Date, ByVal Shift As String, ByVal Quencher As String, ByVal Offload As String, ByVal WheelNo As Long, ByVal Processed As String) As Boolean
            Dim cmd As SqlClient.SqlCommand = rwfGen.Connection.CmdObj
            cmd.Parameters.Add("@HeatNo", SqlDbType.BigInt, 8).Value = HeatNo
            cmd.Parameters.Add("@Offload", SqlDbType.VarChar, 50).Value = Offload
            cmd.Parameters.Add("@OffDate", SqlDbType.SmallDateTime, 4).Value = OffDate
            cmd.Parameters.Add("@Shift", SqlDbType.VarChar, 1).Value = Shift
            cmd.Parameters.Add("@Quencher", SqlDbType.VarChar, 50).Value = Quencher
            cmd.Parameters.Add("@WheelNo", SqlDbType.BigInt, 8).Value = WheelNo
            cmd.Parameters.Add("@Processed", SqlDbType.VarChar, 50).Value = Processed

            Try
                If WheelNo = 0 Then
                    cmd.CommandText = "insert into mm_OffloadList " &
                        " select  engraved_number , @HeatNo , @OffDate , @Shift , @Quencher , @Offload , @Processed " &
                        " from mm_pouring  where heat_number = @HeatNo and engraved_number in " & "(" & WheelList.Trim & ")"
                Else
                    cmd.CommandText = "update mm_OffloadList " &
                        " set  OffDate = @OffDate , Shift = @Shift , Quencher = @Quencher , Offload = @Offload , Processed = @Processed " &
                        " where HeatNo = @HeatNo and WheelNo = @WheelNo "
                End If
                If cmd.Connection.State = ConnectionState.Closed Then cmd.Connection.Open()
                If cmd.ExecuteNonQuery() > 0 Then Return True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            Return 0
        End Function
        Public Function MRRejectionCodes(ByVal MRXC As String, ByVal Reasons As String) As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj
            cmd.Parameters.Add("@MRXC", SqlDbType.VarChar, 50).Value = MRXC
            cmd.Parameters.Add("@Reasons", SqlDbType.VarChar, 50).Value = Reasons
            Dim blnDone As Boolean
            Try
                cmd.Connection.Open()
                cmd.CommandText = " insert into mm_MRXCReasons" & _
                    " ( MRXC , Reasons ) values (@MRXC ,  @Reasons )  "
                If cmd.ExecuteNonQuery = 1 Then blnDone = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            Return blnDone
        End Function
        Public Function WheelNormalising(ByVal HeatNo As Double, ByVal WheelNo As Double, ByVal SIC As String, ByVal OP1 As String, ByVal OP2 As String, ByVal PedNo As Integer, ByVal PedPosition As String, ByVal TimeIn As Date, ByVal TimeOut As Date, ByVal Quencher As String, ByVal Remarks As String) As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj
            cmd.Parameters.Add("@WheelNo", SqlDbType.BigInt, 8).Value = WheelNo
            cmd.Parameters.Add("@HeatNo", SqlDbType.BigInt, 8).Value = HeatNo
            cmd.Parameters.Add("@SIC", SqlDbType.VarChar, 50).Value = SIC
            cmd.Parameters.Add("@OP1", SqlDbType.VarChar, 50).Value = OP1
            cmd.Parameters.Add("@OP2", SqlDbType.VarChar, 50).Value = OP2
            cmd.Parameters.Add("@PedNo", SqlDbType.Int, 4).Value = PedNo
            cmd.Parameters.Add("@PedPosition", SqlDbType.VarChar, 1).Value = PedPosition
            cmd.Parameters.Add("@TimeIn", SqlDbType.SmallDateTime, 4).Value = TimeIn
            cmd.Parameters.Add("@TimeOut", SqlDbType.SmallDateTime, 4).Value = TimeOut
            cmd.Parameters.Add("@Quencher", SqlDbType.VarChar, 50).Value = Quencher
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 50).Value = Remarks
            cmd.Parameters.Add("@cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output
            Dim blnDone As Boolean
            Try
                cmd.Connection.Open()
                'cmd.CommandText = " select @cnt = count(*) from mm_MRXCDetails where WheelNo = @WheelNo and HeatNo = @HeatNo"
                'If IIf(IsDBNull(cmd.Parameters("@cnt").Value), 0, cmd.Parameters("@cnt").Value) = 0 Then
                cmd.CommandText = " insert into mm_WheelNormalising" & _
                        " ( HeatNo , WheelNo , SIC , OP1 , OP2 , PedNo , PedPosition , TimeIn , TimeOut , Quencher , Remarks  ) values  " & _
                        " ( @HeatNo , @WheelNo , @SIC , @OP1 , @OP2 , @PedNo , @PedPosition , @TimeIn , @TimeOut , @Quencher , @Remarks  )  "
                If cmd.ExecuteNonQuery = 1 Then blnDone = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            Return blnDone
        End Function
        Public Function MRRejRemarks(ByVal WheelNo As Double, ByVal HeatNo As Double, ByVal XCId As Integer, ByVal Remarks As String, ByVal LIC As String, ByVal SIC As String) As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj
            cmd.Parameters.Add("@WheelNo", SqlDbType.BigInt, 8).Value = WheelNo
            cmd.Parameters.Add("@HeatNo", SqlDbType.BigInt, 8).Value = HeatNo
            cmd.Parameters.Add("@XCId", SqlDbType.Int, 4).Value = XCId
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 50).Value = Remarks
            cmd.Parameters.Add("@LIC", SqlDbType.VarChar, 50).Value = LIC
            cmd.Parameters.Add("@SIC", SqlDbType.VarChar, 50).Value = SIC
            cmd.Parameters.Add("@cnt", SqlDbType.Int, 4).Direction = ParameterDirection.Output
            Dim blnDone As Boolean
            Try
                cmd.Connection.Open()
                cmd.CommandText = " select @cnt = count(*) from mm_MRXCDetails where WheelNo = @WheelNo and HeatNo = @HeatNo"
                If IIf(IsDBNull(cmd.Parameters("@cnt").Value), 0, cmd.Parameters("@cnt").Value) = 0 Then
                    cmd.CommandText = " insert into mm_MRXCDetails" & _
                        " ( WheelNo , HeatNo , Remarks , XCId , LIC , SIC ) values (@WheelNo ,  @HeatNo , @Remarks , @XCId , @LIC , @SIC )  "
                Else
                    cmd.CommandText = " update mm_MRXCDetails set Remarks = @Remarks , XCId = @XCId ," & _
                        " Remarks = @Remarks where WheelNo = @WheelNo and HeatNo @HeatNo "
                End If
                If cmd.ExecuteNonQuery = 1 Then blnDone = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            Return blnDone
        End Function
        Public Function WheelNormalisingPre(ByVal HeatNo As Double, ByVal WheelNo As Double, ByVal SIC As String, ByVal OP1 As String, ByVal OP2 As String, ByVal PedNo As Integer, ByVal PedPosition As String, ByVal TimeIn As Date, ByVal TimeOut As Date, ByVal Quencher As String, ByVal Remarks As String, ByVal SlNo As Integer) As Boolean
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = rwfGen.Connection.ConObj
            cmd.Parameters.Add("@WheelNo", SqlDbType.BigInt, 8).Value = WheelNo
            cmd.Parameters.Add("@HeatNo", SqlDbType.BigInt, 8).Value = HeatNo
            cmd.Parameters.Add("@SIC", SqlDbType.VarChar, 50).Value = SIC
            cmd.Parameters.Add("@OP1", SqlDbType.VarChar, 50).Value = OP1
            cmd.Parameters.Add("@OP2", SqlDbType.VarChar, 50).Value = OP2
            cmd.Parameters.Add("@PedNo", SqlDbType.Int, 4).Value = PedNo
            cmd.Parameters.Add("@PedPosition", SqlDbType.VarChar, 1).Value = PedPosition
            cmd.Parameters.Add("@TimeIn", SqlDbType.SmallDateTime, 4).Value = TimeIn
            cmd.Parameters.Add("@TimeOut", SqlDbType.SmallDateTime, 4).Value = TimeOut
            cmd.Parameters.Add("@Quencher", SqlDbType.VarChar, 50).Value = Quencher
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 50).Value = Remarks
            cmd.Parameters.Add("@SlNo", SqlDbType.Int, 4).Value = SlNo
            Dim blnDone As Boolean
            Try
                cmd.Connection.Open()
                cmd.CommandText = " update mm_WheelNormalising " & _
                    " set SIC = @SIC  , OP1 = @OP1 , OP2 = @OP2  ," & _
                    " TimeOut = @TimeOut , Quencher = @Quencher , Remarks = @Remarks " & _
                    " where HeatNo = @HeatNo and WheelNo  = @WheelNo and SlNo = @SlNo  and PedNo = @PedNo and PedPosition = @PedPosition"
                If cmd.ExecuteNonQuery = 1 Then blnDone = True
            Catch exp As Exception
                Throw New Exception(exp.Message)
            Finally
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                cmd.Dispose()
                cmd = Nothing
            End Try
            Return blnDone
        End Function
    End Class
End Namespace